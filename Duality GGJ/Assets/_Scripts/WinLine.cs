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
        // stage is not complete and if player passes through the finish line the win event gets triggered once!
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
