using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetTimer : MonoBehaviour
{
    void Awake()
    {
        if(SceneManager.GetActiveScene().name == "level1") //-- level 1
        {
            if (INFO.GAME_TIME < INFO.REC1) INFO.REC1 = INFO.GAME_TIME;
            GetComponent<Text>().text = "time: " + INFO.GAME_TIME.ToString("00.00");
        }

        if (SceneManager.GetActiveScene().name == "level2") //-- level 2
        {
            if (INFO.GAME_TIME < INFO.REC2) INFO.REC2 = INFO.GAME_TIME;
            GetComponent<Text>().text = "time: " + INFO.GAME_TIME.ToString("00.00");
        }

        if (SceneManager.GetActiveScene().name == "level3") //-- level 3
        {
            if (INFO.GAME_TIME < INFO.REC3) INFO.REC3 = INFO.GAME_TIME;
            GetComponent<Text>().text = "time: " + INFO.GAME_TIME.ToString("00.00");
        }
    }
}
