using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{

    public Rect groupPos;

    public Rect scPos;
    public Rect showPos;
    public Vector2 vector2;

    public string[] str = new string[] { "0","1","2"};

    private void OnGUI()
    {
        //分组，类似父子关系
        GUI.BeginGroup(groupPos);
        GUI.Button(new Rect(0, 0, 100, 50), "测试按钮");
        GUI.Label(new Rect(0, 60, 50, 20), "内容");

        GUI.EndGroup();



        //滚动条
        vector2 = GUI.BeginScrollView(scPos, vector2, showPos);
        GUI.Toolbar(new Rect(0, 0, 100, 100), 0, str);
        GUI.Toolbar(new Rect(0,150, 100, 100), 0, str);
        GUI.Toolbar(new Rect(0, 300, 100, 100), 0, str);
        GUI.Toolbar(new Rect(0,450, 100, 100), 0, str);
        GUI.Toolbar(new Rect(0, 600, 100, 100), 0, str);
        GUI.Toolbar(new Rect(0, 750, 100, 100), 0, str);

        GUI.EndScrollView();
    }
}
