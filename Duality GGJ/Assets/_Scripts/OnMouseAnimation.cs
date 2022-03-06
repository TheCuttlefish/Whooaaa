using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMouseAnimation : MonoBehaviour
{

    RectTransform rt;
    bool shake = false; //-- pulsating animation of the selected menu items
    Vector3 oScale;//-- original scale

    void Start()
    {
        rt = GetComponent<RectTransform>();
        oScale = rt.localScale;
    }

    public void StartShake()
    {
        shake = true;
    }

    public void StopShake()
    {
        shake = false;
        rt.localScale = oScale;
    }

    void Update()
    {
        if(shake) rt.localScale = oScale + (new Vector3(1,1,1) * Mathf.Cos(Time.time*15) / 50);
    }
}
