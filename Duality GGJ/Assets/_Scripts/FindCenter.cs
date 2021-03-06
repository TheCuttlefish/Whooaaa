using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCenter : MonoBehaviour
{

    public bool RotateWithMovement = true;
    public List<Transform> points = new List<Transform>();
    Vector3 newPos = new Vector3(0,0,0);

    private void Awake()
    {
        transform.position = transform.parent.position;
    }

    void Update()
    {

    for (int i = 0; i < 3; i++) newPos += points[i].position;//find center based on 3 points

    newPos = (newPos / 4);//average points position
    transform.position -= ( transform.position -  newPos)/ 0.02f * Time.deltaTime;//move object to that position

    if(RotateWithMovement) transform.localEulerAngles = new Vector3(0, 0, Input.GetAxis("Horizontal") * 45);//rotate with momement input

    }
}
