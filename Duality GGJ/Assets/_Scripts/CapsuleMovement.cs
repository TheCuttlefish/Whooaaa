using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    Vector3 pos;//original pos

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        transform.position = pos + new Vector3(0, Mathf.Cos(transform.position.x / 10 + Time.time * 10) * 2 , 0);
    }
}
