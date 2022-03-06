using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnMouseAnimation : MonoBehaviour
{

    RectTransform rt;
    
    bool shake = false;
    Vector3 oScale;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        if(shake)
        rt.localScale = oScale + (new Vector3(1,1,1) * Mathf.Cos(Time.time*15) / 50);
    }
}
