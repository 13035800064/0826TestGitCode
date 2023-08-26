using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    private string inputStr ="";

    float nowValue = 0.5f;
    private void OnGUI()
    {
        inputStr =GUI.TextField(new Rect(0, 0, 100, 30), inputStr,5);

        nowValue = GUI.HorizontalSlider(new Rect(0, 50, 100, 50), nowValue, 0, 1);
        print(nowValue);
    }
}
