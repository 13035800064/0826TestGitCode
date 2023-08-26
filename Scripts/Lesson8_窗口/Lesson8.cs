using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    private Rect rect12 = new Rect(0, 0, 100, 100);
    private Rect rect11 = new Rect(0, 0, 200, 200);
    private void OnGUI()
    {
        GUI.color = Color.blue;
        GUI.contentColor = Color.gray;
        GUI.backgroundColor = Color.red;

        GUI.skin = null;

        rect12 =GUI.Window(1,rect12,(id) => { GUI.DragWindow(new Rect(0,0,500,30)); },"²âÊÔ´°¿Ú");

        //rect11 = GUI.ModalWindow(2, rect11, (id) => { GUI.DragWindow(new Rect(0, 0, 500, 30)); }, "Ä£Ì¬´°¿Ú");
    }

    
}
