using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public LineRenderer line;
    public int sideCount = 3;
    public float side = 4f;

    public float factorX;
    public float factorY;
    public float rotation;

    void Update()
    {
        CreateShape(sideCount, Vector3.zero, side);

        //if (Input.GetMouseButtonDown(0))
        //{
        //    var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    var startPoint = new Vector3(mousePos.x, mousePos.y);

        //    CreateShape(sideCount, startPoint, side);

        //    sideCount++;
        //}
    }

    void CreateShape(int sideCount, Vector3 startPoint, float side)
    {
        line.positionCount = 0;

        var deltaAngle = Mathf.Deg2Rad * 144f; // 360f / sideCount;
        var angle = rotation;

        AddPoint(startPoint);

        var lastPoint = startPoint;

        for (int i = 0; i < sideCount; i++)
        {
            var x = lastPoint.x + Mathf.Cos(angle) * side;
            var y = lastPoint.y + Mathf.Sin(angle) * side;

            var point = new Vector3(x, y);
            AddPoint(point);

            lastPoint = point;
            angle = angle + deltaAngle;
        }
    }

    void AddPoint(Vector3 point)
    {
        line.positionCount++;

        line.SetPosition(line.positionCount - 1, point);
    }
}
