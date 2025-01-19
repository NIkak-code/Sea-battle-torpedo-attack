using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_bnt : MonoBehaviour
{
    public string bntName = null;
    public bool state = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
                bntName = Input.inputString;
                state = true;
        }
    }
}
