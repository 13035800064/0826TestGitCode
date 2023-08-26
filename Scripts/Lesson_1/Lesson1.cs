using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    //public Texture texture;

    public Rect rect;

    public GUIContent content;

    public GUIStyle uIStyle;

    //位置参数 ： Rect
    //显示文本： string
    //图片信息：Texture
    //综合信息 GUIContent
    //自定义样式 GUIStyle
    //Rect rect1 = new Rect(0, 0, 100, 200);
    private void OnGUI()
    {
        //GUI.Label(rect1, "卢老师欢迎你", uIStyle);
        ////GUI.Label(rect, texture);

        //GUI.Label(rect, content);

        //if (GUI.Button(rect, content, uIStyle))
        //{
        //    print("进入游戏");
        //}

        //if (GUI.RepeatButton(rect, content))
        //{
        //    print("chang帅");
        //}
    }
}
