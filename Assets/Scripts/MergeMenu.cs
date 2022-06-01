using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeMenu : MonoBehaviour
{
    public Text mergeValue;

    void Update()
    {
        if (mergeValue != null)
            mergeValue.text = MainMenu.merge.ToString();
    }
}
