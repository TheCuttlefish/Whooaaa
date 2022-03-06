using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerColour : MonoBehaviour
{

    public Color red, orange, green;
    LineRenderer lr;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        if (INFO.CHAR == 0) { lr.startColor = red; lr.endColor = red; }
        if (INFO.CHAR == 1) { lr.startColor = orange; lr.endColor = orange; }
        if (INFO.CHAR == 2) { lr.startColor = green; lr.endColor = green; }
    }

  
}
