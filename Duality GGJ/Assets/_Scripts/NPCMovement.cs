using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{

    Rigidbody2D rb;
    public int changeDir=0; //direction is either 0 or 1 (right or left)
    float timer; // -- this is a timer for changing direction

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // NPC AI (if you can call it that :D )
        // based on time NPC can change its direction
        timer += Time.fixedDeltaTime;
        if(timer > 0)
        {
            timer = Random.Range(-5f, 0f);
            changeDir = Random.Range(0, 2);
        }
    }

    void FixedUpdate()
    {
        if (changeDir == 0)
        {
            rb.AddTorque(-80);
            rb.AddForce(Vector2.right * 80);
        }
        else {
            rb.AddForce(Vector2.right * -80);
            rb.AddTorque(80);
        }
    }
}
