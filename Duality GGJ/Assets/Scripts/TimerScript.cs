using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



    



public class TimerScript : MonoBehaviour
{
    Text t;
    float timer = 0;
    bool pause = false;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
    }

    public void Pause()
    {
        pause = true;
    }
    // Update is called once per frame
    void Update()
    {

        if (pause) return;
        timer += Time.deltaTime;
        INFO.GAME_TIME = timer;
        t.text = "time: " + timer.ToString("00.00");
    }
}
