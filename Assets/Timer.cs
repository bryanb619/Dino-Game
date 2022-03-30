using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject _textTimer;

    public int _SecondLeft = 30;

    public bool _takingAway = false;


    void Start()
    {
        _textTimer.GetComponent<Text>().text = "00:" + _SecondLeft;

    }

    void Update()
    {
        if (_takingAway = false && _SecondLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        
    }

    IEnumerator TimerTake()
    {
        _takingAway = true;
        yield return new WaitForSeconds(1);
        _SecondLeft -= 1;

        _textTimer.GetComponent<Text>().text = "00:" + _SecondLeft;
        _takingAway = false;

    }

}
