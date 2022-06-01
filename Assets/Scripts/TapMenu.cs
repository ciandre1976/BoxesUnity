using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapMenu : MonoBehaviour
{
    
    public Text tapValue;

   
    
    void Update()
    {
        if (tapValue != null)
        tapValue.text = MainMenu.counter.ToString();
     
    }
}
