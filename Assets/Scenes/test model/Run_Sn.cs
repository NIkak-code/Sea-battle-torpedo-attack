using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Sn : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject camera_pos;

    void Start()
    {
        this.camera_pos = GameObject.FindGameObjectWithTag("GameController");
        transform.rotation=camera_pos.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward;
        Vector2 V = new Vector2(transform.position.x, transform.position.z);
        if (transform.position.magnitude>150f)
        {
            Destroy(gameObject);
        }
    }
}
