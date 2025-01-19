using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using System;

public class Spawn_en : MonoBehaviour
{
    public GameObject Enemi;
    private float swaptime;
    private int maxObj = 9;
    private float angle; 
    void Start()
    {
        swaptime = 20f + Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > swaptime)
        {
            swaptime = Time.time + UnityEngine.Random.Range(15f,25f);
            if (GameObject.FindGameObjectsWithTag("Enemi").Length <= maxObj)
            {
                angle = UnityEngine.Random.Range(0f, 360f);
                GameObject newEn = Instantiate(Enemi, new Vector3(UnityEngine.Random.Range(100f, 150f), 3f, 0), Quaternion.identity);
                newEn.transform.RotateAround(new Vector3(0, 0, 0), Vector3.up,angle);
            }
        }
    }
}
