using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        INFO.VEL_MAG = rb.velocity.magnitude;

        if(Physics2D.gravity.y < 0)
        GetComponent<Rigidbody2D>().AddTorque(-4000 * Input.GetAxis("Horizontal") * Time.deltaTime );
        else GetComponent<Rigidbody2D>().AddTorque(4000 * Input.GetAxis("Horizontal") * Time.deltaTime);

     
            //GetComponent<Rigidbody2D>().AddForce(Vector2.right * 50 * Input.GetAxis("Horizontal"));
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * 10000 * Input.GetAxis("Horizontal") * Time.deltaTime);

    }
}
