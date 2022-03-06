using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongue : MonoBehaviour
{
    LineRenderer lr;
    public Transform face;
    public Transform tongue;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, face.transform.position);
        lr.SetPosition(1, tongue.transform.position);
    }
}
