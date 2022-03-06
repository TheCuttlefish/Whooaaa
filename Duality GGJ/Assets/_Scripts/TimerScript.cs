using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Text t;
    float timer = 0;
    bool pause = false;

    void Start()
    {
        t = GetComponent<Text>();
    }

    void Update()
    {
        if (pause) return; // -- if paused then don't increase time
        timer += Time.deltaTime; //-- increase time
        INFO.GAME_TIME = timer; //-- pass time into static class to later check if this is time is a new record
        t.text = "time: " + timer.ToString("00.00"); // -- time formatting
    }

    public void Pause()
    {
        pause = true;
    }
}
