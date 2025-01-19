using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
    public void LoadOptScene()
    {
        SceneManager.LoadScene("Option");
    }
    public void LoadScoreScene()
    {
        SceneManager.LoadScene("Score");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
