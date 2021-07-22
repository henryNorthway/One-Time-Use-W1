using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _ResetCounter : MonoBehaviour
{
    public static int _scoreValue = 0;
    Text _score;

    // Start is called before the first frame update
    void Start()
    {
        _score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _score.text = "Player Resets: " + _scoreValue;
    }
}
