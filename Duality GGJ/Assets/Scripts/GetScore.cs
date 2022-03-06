using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GetScore : MonoBehaviour
{

    Text t;
    private void Start()
    {
        t = GetComponent<Text>();
        if (SceneManager.GetActiveScene().name == "level1") t.text = "rec: " + INFO.REC1.ToString("00.00");
        if (SceneManager.GetActiveScene().name == "level2") t.text = "rec: " + INFO.REC2.ToString("00.00");
        if (SceneManager.GetActiveScene().name == "level3") t.text = "rec: " + INFO.REC3.ToString("00.00");
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "level1") t.text = "rec: " + INFO.REC1.ToString("00.00");
        if (SceneManager.GetActiveScene().name == "level2") t.text = "rec: " + INFO.REC2.ToString("00.00");
        if (SceneManager.GetActiveScene().name == "level3") t.text = "rec: " + INFO.REC3.ToString("00.00");
    }
}
