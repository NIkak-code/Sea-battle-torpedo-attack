using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CameraSc : MonoBehaviour
{
    public float rotationSp = 20F;
    public GameObject Sn;

    void Start()
    {
    }

    void Update()
    {
        if(Input.inputString == (PlayerPrefs.GetString("Keycode_A")))
        {
            transform.Rotate(0, rotationSp * Time.deltaTime * (-1), 0);
        }
        if (Input.inputString == (PlayerPrefs.GetString("Keycode_D")))
        {
            transform.Rotate(0, rotationSp * Time.deltaTime, 0);
        }
        if (Input.inputString == (PlayerPrefs.GetString("Keycode_E")))
        {
            if (GameObject.FindGameObjectsWithTag("Snaryd").Length == 0)
            { Instantiate(Sn, new Vector3(0f, 0f, 0f), Quaternion.identity); }
        }
    }
}
