using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  this is a static class, this should probably be its own class
public static class INFO
{
    public static float VEL_MAG = 0;
    public static float GAME_TIME = 0;
    public static float MAX_TIME = 60;

    public static int CHAR = 0;

    public static float REC1 = 60;
    public static float REC2 = 60;
    public static float REC3 = 60;
}

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HorizontalMovement();
        INFO.VEL_MAG = rb.velocity.magnitude;//-- player magnitude is used by points (for line renderer), to control their delay time (to create that fluid line renderer look)
    }

    void HorizontalMovement()
    {
        //rotate in different direction based on current
        if (Physics2D.gravity.y < 0) GetComponent<Rigidbody2D>().AddTorque(-4000 * Input.GetAxis("Horizontal") * Time.deltaTime);
        else GetComponent<Rigidbody2D>().AddTorque(4000 * Input.GetAxis("Horizontal") * Time.deltaTime);

        //move into direction using force
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * 10000 * Input.GetAxis("Horizontal") * Time.deltaTime);
    }
}
