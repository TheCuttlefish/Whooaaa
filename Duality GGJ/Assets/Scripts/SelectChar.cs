using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectChar : MonoBehaviour
{

    public CanvasGroup c1, c2, c3;

    
    // Start is called before the first frame update
    void Start()
    {
        if (INFO.CHAR == 0) Red();
        if (INFO.CHAR == 1) Orange();
        if (INFO.CHAR == 2) Green();

    }

    

    public void Red()
    {
        INFO.CHAR = 0;
        c1.alpha = 1f;
        c2.alpha = 0.4f;
        c3.alpha = 0.4f;
    }

    public void Orange()
    {
        INFO.CHAR = 1;
        c1.alpha = 0.4f;
        c2.alpha = 1f;
        c3.alpha = 0.4f;
    }

    public void Green()
    {
        INFO.CHAR = 2;
        c1.alpha = 0.4f;
        c2.alpha = 0.4f;
        c3.alpha = 1f;
    }

   

}
