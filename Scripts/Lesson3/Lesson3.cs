using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    private bool isSel;
    private bool isSe2;

    public GUIStyle style;

    private int index =1;
    private void OnGUI()
    {
        if( GUI.Toggle(new Rect(0,0,100,30), index == 1, "Ч������1"))
            index = 1;

        if( GUI.Toggle(new Rect(0, 50, 100, 30), index == 2, "��Ч����2"))
            index =2;

        if(GUI.Toggle(new Rect(0, 100, 100, 30), index==3, "��Ч����3"))
            index = 3;

        isSe2=  GUI.Toggle(new Rect(0, 150, 100, 30), isSe2, "JJJJ1");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
