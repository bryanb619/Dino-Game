using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
using Wilberforce;

public class ColorBlindController : MonoBehaviour
{

    [SerializeField] private Dropdown ColorBlindDropDown;
    [SerializeField] private Colorblind colorblindScript;


    private void Awake()
    {
        ColorBlindDropDown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    private void OnDropdownValueChanged(int arg0)
    {
        switch (arg0)
        {
            case 0:
                colorblindScript.Type = 0;


                break;
            case 1:
                colorblindScript.Type = 1;

                break;
            case 2:
                colorblindScript.Type = 2;

                break;
            case 3:
                colorblindScript.Type = 3;

                break;
            default:
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
