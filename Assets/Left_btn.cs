using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Left_btn : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI.text = "Left: " + PlayerPrefs.GetString("Keycode_A");
    }

    private void Update()
    {
        textMeshProUGUI.text = "Left: " + PlayerPrefs.GetString("Keycode_A");
    }

}
