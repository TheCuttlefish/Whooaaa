using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is a behaviour that makes points follow the player at different speeds
public class PointPos : MonoBehaviour
{

    Transform anchorPoint;//anchor points are attached on player, so that these points can follow them with delay
    float offset = 0;
    float newValue = 0;
    float currentValue = 1;

    void Awake()
    {
        anchorPoint = transform.parent;
        transform.parent = null; // detaching points from the player, so that they can follow the player later

        offset = Random.Range(2, 11); // each point  has a different offset value
        transform.position = anchorPoint.transform.position;
    }

    void Update()
    {
        // points follow player at different speeds depends on players speed ( this creates that soft-body look)
        if (INFO.VEL_MAG < 30) newValue = (2 + offset);
        else newValue = (2);

        currentValue -= (currentValue - newValue) / 0.1f * Time.deltaTime; // delaying transition value
        transform.position -= (transform.position - anchorPoint.position) / currentValue * Time.deltaTime * 100; //delaying position
  
    }
}
