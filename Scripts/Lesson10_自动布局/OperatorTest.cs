using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorTest : MonoBehaviour
{
    void Start()
    {
        Point p1 = new Point();
        Point p2 = new Point();
        p1.x = 1;
        p1.y = 1;
        p2.x = 2;
        p2.y = 2;

        Point p3 = p1 + p2;
        print(p3.x);
        print(p3.y);
    }

}

public class Point
{
    public int x;
    public int y;
    public static Point operator +(Point p1,Point p2)
    {
        Point p = new Point();
        p.x = p1.x + p2.x;
        p.y = p1.y + p2.y;
        return p;
    }
}
