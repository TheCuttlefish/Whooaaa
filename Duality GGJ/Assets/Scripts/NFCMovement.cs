using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NFCMovement : MonoBehaviour
{

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    float timer;
    public int changeDir=0;
    private void Update()
    {
        timer += Time.fixedDeltaTime;
        if(timer > 0)
        {
            timer = Random.RandomRange(-5f, 0f);
            changeDir = Random.Range(0, 2);
        }
    }

    // Update is called once per frame
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
