using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reta : MonoBehaviour
{
    public LineRenderer line;
    public float x, y, frequencia, amplitude;

    public float raio = 2f;
    public float angle = 0;
    void Start()
    {
       
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            x = Mathf.Cos(angle) * raio;
            y = Mathf.Sin(angle) * raio;

            AddPoint(new Vector3(x, y));
            angle += Time.deltaTime;
            raio -= Time.deltaTime * 0.02f;
        }
    }
    void AddPoint(Vector3 point)
    {
        line.positionCount++;

        line.SetPosition(line.positionCount - 1, point);
    }
}
