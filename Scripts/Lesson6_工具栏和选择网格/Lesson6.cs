    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    //int slele = 2;
    string[] str = new string[] { "1", "2", "3" };

    int indexOfSelect = 0;

    //int gridIndex;
    private void OnGUI()
    {
        //工具栏
        indexOfSelect = GUI.Toolbar(new Rect(0,0,200,50), indexOfSelect, str);
        switch (indexOfSelect)
        {
            case 0:
                print("强化界面1");
                break;
            case 1:
                print("强化界面2");
                break;
            case 2:
                print("强化界面3");
                break;
            default:
                break;
        }

        //选择网格
        //gridIndex = GUI.SelectionGrid(new Rect(0,100, 200, 50), gridIndex, str,3);
    }
}
