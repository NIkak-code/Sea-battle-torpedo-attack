using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Write_Score : MonoBehaviour
{
    // Start is called before the first frame update
    public int Score = 0;
    public TextMeshProUGUI myText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Score: " + Score.ToString();
    }
}
