using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Dvizh : MonoBehaviour
{
    public float rotationAmount=-1f;
    private GameObject sn;
    private GameObject score; 
    
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("EditorOnly");
    }
    
   
    
    private void Update()
    {
        transform.RotateAround(new Vector3(0,0,0) , Vector3.up, rotationAmount * Time.deltaTime);
        this.sn = GameObject.FindGameObjectWithTag("Snaryd");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Snaryd")
        {
            Destroy(sn); 
            Destroy(gameObject);
            Score_plus();
        }
    }
    private void Score_plus()
    {
        int score_n = this.score.GetComponent<Write_Score>().Score + 50;
        this.score.GetComponent<Write_Score>().Score = score_n;
    }
}
