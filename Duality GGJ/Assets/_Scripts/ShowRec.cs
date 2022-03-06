using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowRec : MonoBehaviour
{

    public float level = 1;

    void Awake()
    {
        if (level == 1) GetComponent<Text>().text = INFO.REC1.ToString("00.00");
        if (level == 2) GetComponent<Text>().text = INFO.REC2.ToString("00.00");
        if (level == 3) GetComponent<Text>().text = INFO.REC3.ToString("00.00");
    }

}
