using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    public int RotateSpeed;
    void Update()
    {
        transform.Rotate(0, 0, RotateSpeed * Time.deltaTime);
    }
}
