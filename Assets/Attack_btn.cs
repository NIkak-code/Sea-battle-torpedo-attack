using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Attack_btn : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI.text = "Attack: " + PlayerPrefs.GetString("Keycode_E");
    }

    // Update is called once per frame
    void Update()
    {
        textMeshProUGUI.text = "Attack: " + PlayerPrefs.GetString("Keycode_E");
    }
}
