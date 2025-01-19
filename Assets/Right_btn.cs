using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Right_btn : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI.text = "Right: " + PlayerPrefs.GetString("Keycode_D");
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = "Right: " + PlayerPrefs.GetString("Keycode_D");
    }
}
