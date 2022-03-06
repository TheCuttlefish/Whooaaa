using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//hidden places behaviour 
public class Hidden : MonoBehaviour
{

    public Color full, invisible;
    Color setColour;
    SpriteRenderer sr;

    void Start()
    {
        setColour = full;
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        sr.color -= (sr.color - setColour) / 0.1f * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player") setColour = invisible;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") setColour = full;
        
    }

}
