using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class WinLine : MonoBehaviour
{
    public UnityEvent win;
    bool winState = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!winState)
            {
                win.Invoke();
                winState = true;
            }
        }
    }
}
