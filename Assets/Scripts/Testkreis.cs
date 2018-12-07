using UnityEngine;
using System.Collections;
using System;

public class Testkreis : MonoBehaviour
{
    // Creates a line renderer that follows a Sin() function
    // and animates it.

    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    public int lengthOfLineRenderer = 100;
    public Vector3[] points = new Vector3[100];

    void Start()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.widthMultiplier = 0.2f;
        lineRenderer.positionCount = lengthOfLineRenderer;

        // A simple 2 color gradient with a fixed alpha of 1.0f.
        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
            );
        lineRenderer.colorGradient = gradient;
    }

    void FixedUpdate()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        points = new Vector3[lengthOfLineRenderer];
        // var t = Time.time;
        for (int i = 0; i < lengthOfLineRenderer; i++)
        {
    
            points[i] = new Vector3(10 * Mathf.Cos(2 * i *(Mathf.PI/lengthOfLineRenderer)), 
                                    1 , 
                                    10 * Mathf.Sin(2* i *(Mathf.PI/lengthOfLineRenderer))
                                    );
            
        }
        lineRenderer.SetPositions(points);
    }
}