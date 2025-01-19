using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Best_Score : MonoBehaviour
{
    public TextMeshProUGUI myText;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Best Score\n" + PlayerPrefs.GetInt("Score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
