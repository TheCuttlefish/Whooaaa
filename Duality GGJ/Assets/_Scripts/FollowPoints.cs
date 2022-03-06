using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoints : MonoBehaviour
{

    public List<Transform> points = new List<Transform>();
    LineRenderer lr;
    float timer = 0;
    bool showTimer = true;


    private void Awake()
    {

        lr = GetComponent<LineRenderer>();//find line renderer

        for (int i = 0; i < 8; i++) lr.SetPosition(i, points[i].position);//assign line to points

    }

    void Update()
    {

        if (showTimer) //-- this is here to get rid of graphical glitch when line does not assign to points at start of the game, so the line stays hidden for fraction of a second
        {
            timer += Time.deltaTime;
            if (timer > 0.01f)
            {
                lr.startWidth = 1;
                lr.endWidth = 1;
                showTimer = false;
            }
            
        }


        for (int i = 0; i < 8; i++) lr.SetPosition(i, points[i].position);//assign line to points
        
    }
}
