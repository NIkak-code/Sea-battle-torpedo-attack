using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Animation : MonoBehaviour
{
    // Start is called before the first frame update
    private int i = 0;
    public TextMeshProUGUI load_text;
    

    void FixedUpdate()
    {
        // ��������� ������ �������� ������ 3 �������
        if (Time.fixedTime - lastFixedUpdateTime > 3f)
        {
            lastFixedUpdateTime = Time.fixedTime; // ��������� ����� ���������� �������������� ����������
            switch (i) 
            {
                case 0:
                    i++;
                    load_text.text = "Load";
                    break;
                case 1:
                    i++;
                    load_text.text = "Load.";
                    break;
                case 2:
                    i++;
                    load_text.text = "Load..";
                    break;
                case 3:
                    i = 0;
                    load_text.text = "Load...";
                    break;
            } 
                
        }
    }

    private float lastFixedUpdateTime;
}
