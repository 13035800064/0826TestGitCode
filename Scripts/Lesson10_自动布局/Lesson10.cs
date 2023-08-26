using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    private void OnGUI()
    {
        //GUILayout.BeginHorizontal();
        //GUILayout.Button("666", GUILayout.ExpandWidth(false));
        //GUILayout.Button("62e266");
        //GUILayout.Button("662346");
        //GUILayout.EndHorizontal();
       
    }

    private void Start()
    {
        int[] array1 = new int[] { 1, 50, 88, 64, 241, 7 };
        SelectSort(array1);
        foreach (int num in array1)
        {
            print(num);
        }

        Person p = new Person();
        p[0] = new Person();
    }
    private void SelectSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int index = 0;
            for (int j = 1; j < arr.Length - i; j++)//´íÎó£ºarr.Length - 1 - i
            {
                if (arr[index] < arr[j])
                {
                    index = j;
                }
            }
            if (index != arr.Length-1-i)
            {
                int temp = arr[index];
                arr[index] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }
    }


}

public class Person
{
    private string name;
    private int age;
    private int[,] array;
    private Person[] friends;

    public Person this[int index]
    {
     
        get
        {
            return friends[index];
        }
        set
        {
            friends[index] = value;
        }
    }

    public string this[string str]
    {
        get
        {
            return str;
        }
    }

    public int this[int i,int j]
    {
        get
        {
            return array[i, j];
        }
    }
}

public class IntArray
{
    private int[] array;

    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value;
        }
    }

    public IntArray()
    {
        
    }
}
