using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obnovl : MonoBehaviour
{
    public Button left;
    public Button right;
    public Button attack;
    public GameObject nb;
    GameObject locnb;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void buttonCallBack_left()
    {
        i = 1;
    }
    public void buttonCallBack_right()
    {
        i = 2;
    }
    public void buttonCallBack_attack()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (i!=0)
        {
            if (GameObject.FindGameObjectsWithTag("inputkey").Length==0) { locnb = Instantiate(nb, new Vector3(0f, 0f, 0f), Quaternion.identity);}
            
            switch (i)
            {
                case 1:
                    if (locnb.GetComponent<New_bnt>().state) 
                    { 
                        Debug.Log(locnb.GetComponent<New_bnt>().bntName);
                        PlayerPrefs.SetString("Keycode_A", locnb.GetComponent<New_bnt>().bntName);
                        i = 0;
                        Destroy(locnb);
                        locnb.GetComponent<New_bnt>().state = false;
                    }
                    break;
                case 2:
                    if (locnb.GetComponent<New_bnt>().state)
                    {
                        PlayerPrefs.SetString("Keycode_D", locnb.GetComponent<New_bnt>().bntName);
                        i = 0;
                        Destroy(locnb);
                        locnb.GetComponent<New_bnt>().state = false;
                    }
                    break;
                case 3:
                    if (locnb.GetComponent<New_bnt>().state)
                    {
                        PlayerPrefs.SetString("Keycode_E", locnb.GetComponent<New_bnt>().bntName);
                        i = 0;
                        Destroy(locnb);
                        locnb.GetComponent<New_bnt>().state = false;
                    }
                    break;
            }
        }
    }
}
