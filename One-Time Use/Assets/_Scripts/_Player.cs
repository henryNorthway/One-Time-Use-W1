using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class _Player : MonoBehaviour
{
    _InputAction _playerControls;

    Vector3 _initialPosition;
    Quaternion _initialRotation;

    int _playerSpeed = 3;
    Vector2 _playerMove;
    private AudioSource _deathSFX;

    float _turnSmoothTime = 0.1f;
    float _turnSmoothVelocity;

    public _PlayerAnimation _playerAnimator;
    public bool _isGrounded;
    bool _isDead = false;
    bool _isNearby = false;

    public GameObject _floatingTextPrefab;
    private GameObject _floatingText;

    public _PauseGame _pauseMenu;
    public _TimeManager _timeManager;

    void Awake()
    {
        _playerControls = new _InputAction();

        _playerControls._userActions._Interact.performed += ctx => Interact();
        _playerControls._userActions._Pause.performed += ctx => Pause();
        _playerControls._userActions._Jump.performed += ctx => Jump();

        _playerControls._userActions._Move.performed += ctx => _playerMove = ctx.ReadValue<Vector2>();
        _playerControls._userActions._Move.canceled += ctx => _playerMove = Vector2.zero;

        _deathSFX = GetComponent<AudioSource>();
    }

    void Start()
    {
        _initialPosition = transform.position;
        _initialRotation = transform.rotation;
    }

    void Update()
    {
        Vector3 _playerMovement = new Vector3(_playerMove.x, 0.0f, _playerMove.y);

        float _targetAngle = Mathf.Atan2(_playerMovement.x, _playerMovement.z) * Mathf.Rad2Deg;
        float _angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, _targetAngle, ref _turnSmoothVelocity, _turnSmoothTime);

        transform.Translate(_playerMovement * _playerSpeed * Time.deltaTime, Space.World);

        if (_playerMovement != Vector3.zero)
        {
            transform.rotation = Quaternion.Euler(0f, _angle, 0f);
            _playerAnimator.Moving(true);
        }
        else
        {
            _playerAnimator.Moving(false);
        }

        if (transform.position.y < -5 && !_isDead)
        {
            Death();
        }

        if (_isGrounded)
        {
            _playerAnimator.Jumping(true);
        }
        else
        {
            _playerAnimator.Jumping(false);
        }
    }

    void OnTriggerEnter(Collider _objectCollision)
    {
        if (_objectCollision.gameObject.tag == "Object" && !_isNearby)
        {
            _isNearby = true;

            ShowFloatingText();
        }

        if (_objectCollision.gameObject.tag == "Pressure Plate" && _isGrounded)
        {
            FindClosestObject();
        }

        if (_objectCollision.gameObject.tag == "Respawn" && !_isDead)
        {
            Death();
        }
    }

    void OnTriggerExit(Collider _objectCollision)
    {
        if (_objectCollision.gameObject.tag == "Object" && _isNearby)
        {
            _isNearby = false;

            DestroyFloatingText();
        }
    }

    void OnCollisionStay(Collision _objectCollision)
    {
        if (_objectCollision.gameObject.tag == "Ground")
        {
            _isGrounded = true;
        }
    }

    void OnCollisionExit()
    {
        _isGrounded = false;
    }

    public void ShowFloatingText()
    {
        _floatingText = Instantiate(_floatingTextPrefab, transform.position, Quaternion.identity, transform);
    }

    public void DestroyFloatingText()
    {
        Destroy(_floatingText);
    }

    void Interact()
    {
        if (_isNearby && _isGrounded)
        {
            FindClosestObject();
        }
    }

    void Jump()
    {
        if (_isGrounded)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * 5;
            _isGrounded = false;
        }
    }

    void FindClosestObject()
    {
        float _distanceToClosestObject = Mathf.Infinity;
        _Trap _closestObject = null;
        _Trap[] _allObjects = GameObject.FindObjectsOfType<_Trap>();

        foreach (_Trap _currentObject in _allObjects)
        {
            float _distanceToObject = (_currentObject.transform.position - this.transform.position).sqrMagnitude;

            if (_distanceToObject < _distanceToClosestObject)
            {
                _distanceToClosestObject = _distanceToObject;
                _closestObject = _currentObject;
            }
        }

        _closestObject.TriggerTrap();
    }

    void Death()
    {
        OnDisable();
        _isDead = true;
        _playerAnimator.Dead(true);
        _deathSFX.Play(0);
        _timeManager.SlowMotion();
    }

    public void Respawn()
    {
        OnEnable();
        transform.position = _initialPosition;
        transform.rotation = _initialRotation;
        _ResetCounter._scoreValue += 1;
        _isDead = false;
        _playerAnimator.Dead(false);
    }

    void Pause()
    {
        _pauseMenu.PauseGame();
    }

    public void OnEnable()
    {
        _playerControls._userActions.Enable();
    }

    public void OnDisable()
    {
        _playerControls._userActions.Disable();
    }
}
