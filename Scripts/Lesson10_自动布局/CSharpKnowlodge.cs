using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CSharpKnowlodge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //MyClass myClass = new MyClass(22,"shuai");
        //print(myClass.age);
        //print(myClass.name);

        //手动触发垃圾回收方法
        //一般在情况下，进行Loading条的时候释放
        //GC.Collect();
    }

}


public class MyClass
{
    public int age;
    public string name;
    public MyClass()
    {
        age = 19;
        name = "LuTeacher";
    }
    public MyClass(int age,string name):this()
    {
        this.age = age;
        this.name = name;
    }
}
