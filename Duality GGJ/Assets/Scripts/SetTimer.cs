using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetTimer : MonoBehaviour
{
    
 
    


    void Awake()
    {

        //lev 1
        if(SceneManager.GetActiveScene().name == "level1")
        {
            if (INFO.GAME_TIME < INFO.REC1) INFO.REC1 = INFO.GAME_TIME;
            GetComponent<Text>().text = "time: " + INFO.GAME_TIME.ToString("00.00");
        }

        // lev 2
        if (SceneManager.GetActiveScene().name == "level2")
        {
            if (INFO.GAME_TIME < INFO.REC2) INFO.REC2 = INFO.GAME_TIME;
            GetComponent<Text>().text = "time: " + INFO.GAME_TIME.ToString("00.00");
        }

        // lev 3
        if (SceneManager.GetActiveScene().name == "level3")
        {
            if (INFO.GAME_TIME < INFO.REC3) INFO.REC3 = INFO.GAME_TIME;
            GetComponent<Text>().text = "time: " + INFO.GAME_TIME.ToString("00.00");
        }
    }

}
