using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPos : MonoBehaviour
{

    Transform pTran;
    float offset = 0;
    float newValue = 0;
    float currentValue = 1;

    // Start is called before the first frame update
    void Awake()
    {
        pTran = transform.parent;
        transform.parent = null;

        offset = Random.Range(2, 11);
        transform.position = pTran.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (INFO.VEL_MAG < 30) newValue = (2 + offset);
        else newValue = (2);

        currentValue -= (currentValue - newValue) / 0.1f * Time.deltaTime;
        transform.position -= (transform.position - pTran.position) / currentValue * Time.deltaTime * 100;
  
    }
}
