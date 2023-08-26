using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    public Rect texPos;
    public Texture txt;
    public ScaleMode mode = ScaleMode.ScaleToFit;
    public bool alptha = false;
    public float wh = 0;

    public Rect kkkkpos;

    private void OnGUI()
    {
       
        GUI.DrawTexture(texPos,txt,mode,alptha,wh);
        GUI.Label(kkkkpos, "也得也得");
    }
}
