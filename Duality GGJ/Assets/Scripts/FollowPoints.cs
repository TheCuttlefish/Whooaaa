using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPoints : MonoBehaviour
{

    public List<Transform> points = new List<Transform>();
    LineRenderer lr;

    // Start is called before the first frame update
    private void Awake()
    {

        

        lr = GetComponent<LineRenderer>();
        
        for (int i = 0; i < 8; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
        
    }

    float timer = 0;
    bool showTimer = true;
    // Update is called once per frame
    void Update()
    {
        

        if (showTimer)
        {
            timer += Time.deltaTime;
            if (timer > 0.01f)
            {
                lr.startWidth = 1;
                lr.endWidth = 1;
                showTimer = false;
            }
            
        }


        for (int i =0; i < 8; i++)
        {
            lr.SetPosition(i, points[i].position);
        }

       
    }
}
