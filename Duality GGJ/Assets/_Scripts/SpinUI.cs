using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this spins UI elements (records)
public class SpinUI : MonoBehaviour 
{
    RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * 100);
    }
}
