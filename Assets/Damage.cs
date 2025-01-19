using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    

    private int health = 100;
    private float timer;
    public Image im;
    private int randomNumber;
    void Start()
    {
        timer = 50 + Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timer)
        {
            timer += 30;
            randomNumber = Random.Range(2, 6);
            health -= randomNumber*GameObject.FindGameObjectsWithTag("Enemi").Length;
            im.rectTransform.sizeDelta = new Vector2(health, 20);
        }
        if (health <= 0)
        {
            if(GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<Write_Score>().Score > PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("Score", GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<Write_Score>().Score);
            }
            SceneManager.LoadScene("Game_Over");

        }
    }
}
