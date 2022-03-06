using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidden : MonoBehaviour
{


  
    public Color full, invisible;
    Color setColour;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        setColour = full;
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
          
            setColour = invisible;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
          
            setColour = full;
        }
    }


    // Update is called once per frame
    void Update()
    {
        

        sr.color -= (sr.color - setColour) / 0.1f * Time.deltaTime;
    }
}
