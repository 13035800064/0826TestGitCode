using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sTATICcLASS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 10;
        i.TuoZhanMethod();
        string str = "呵呵呵，大头宝宝";
        str.TuoZhanString("帅");

        Vector2 vector2 = new Vector2();
        vector2.TuoZhanVector();
    }
   
}

public static class HeClass
{
    public static void TuoZhanMethod(this int value)
    {
        Debug.Log("为int拓展的方法"+value);
    }

    public static void TuoZhanString(this string str1,string str2)
    {
        Debug.Log("我拓展的方法"+str2);
        Debug.Log("调用方法的对象" + str1);
    }

    public static void TuoZhanVector(this Vector2 ss)
    {

    }
}
