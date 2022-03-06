using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    Vector3 pos;
    [Range(0f, 20f)]
    public float frequency = 1, amp = 10;
    [Range(-1f, 1f)]
    public float offset = 0;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = pos + transform.up * Mathf.Cos(offset + Time.timeSinceLevelLoad * frequency) * amp;
    }
}
