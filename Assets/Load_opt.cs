using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_opt : MonoBehaviour
{
    public static bool firstLaunch = true;

    void Start()
    {
        int firstLaunchValue = PlayerPrefs.GetInt("FirstLaunch");
        if (firstLaunchValue==0)
        {
            PlayerPrefs.SetInt("FirstLaunch", 1);
            PlayerPrefs.SetString("Keycode_A", "a");
            PlayerPrefs.SetString("Keycode_D", "d");
            PlayerPrefs.SetString("Keycode_E", "e");
            PlayerPrefs.SetInt("Score", 0);
        }
        SceneManager.LoadScene("menu");

    }
}
