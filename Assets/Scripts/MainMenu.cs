using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  class MainMenu : MonoBehaviour
{
    public static int counter = 0;
    public static int merge=0;



    void Update()
    {
        TapButton();
    }

    public  void TapButton()
    {
       if(Input.GetMouseButtonDown(0))
        {
            counter++;
            if ((counter % 10) == 0)
            { merge = counter/10; }
        }
   
    }
}
