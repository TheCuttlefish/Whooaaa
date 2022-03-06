using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

[ExecuteInEditMode]
public class AccesPoints : MonoBehaviour
{

    LineRenderer lineRen;
    public List<Transform> points = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        lineRen = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

       
        //spline.SetPosition(0, points[0].position);

        for (int i = 0; i < 6; i++)
        {
            lineRen.SetPosition(i, points[i].position);

        }
        //GetComponent<SplineControlPoint>().
    }
}
