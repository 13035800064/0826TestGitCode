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
        string str = "�ǺǺǣ���ͷ����";
        str.TuoZhanString("˧");

        Vector2 vector2 = new Vector2();
        vector2.TuoZhanVector();
    }
   
}

public static class HeClass
{
    public static void TuoZhanMethod(this int value)
    {
        Debug.Log("Ϊint��չ�ķ���"+value);
    }

    public static void TuoZhanString(this string str1,string str2)
    {
        Debug.Log("����չ�ķ���"+str2);
        Debug.Log("���÷����Ķ���" + str1);
    }

    public static void TuoZhanVector(this Vector2 ss)
    {

    }
}
