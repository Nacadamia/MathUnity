using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Instantiation_Curve : MonoBehaviour
{
    public Transform brick;

    public Transform playerC;

    //public ArrayList<Vector3> points = new ArrayList<Vector3>(); 
    //public Transform[] wayPoints = new Transform[100];
    private const int PUNKTMENGE = 400;
    public Vector3[] points = new Vector3[PUNKTMENGE];

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        for (int x = -5; x < points.Length; x++)
        {
            Instantiate(brick, new Vector3(FvonT(x), 1, GvonT(x)), Quaternion.identity);
            Instantiate(brick, new Vector3(0.90f * FvonT(x), 1, 0.90f * GvonT(x)), Quaternion.identity);
            Vector3 posVector = new Vector3(1, (float) 0.95 * FvonT(x), (float) 0.95 * GvonT(x));
            points[x + 5] = posVector;
            Instantiate(playerC, posVector, Quaternion.identity);
        }
    }


    void Start()
    {
    }

    float FvonT(float t)
    {
        float x = (Mathf.Pow(t, 2) / points.Length);
        return x;
    }

    float FvonT_inner(float t)
    {
        float x = (Mathf.Pow(t, 2) / points.Length);
        return (float) 0.9 * x;
    }

    float GvonT(float t)
    {
        float z = ((Mathf.Pow(1 * t, 3) - 3 * t) / points.Length);
        return z;
    }

    float GvonT_inner(float t)
    {
        float z = ((Mathf.Pow(1 * t, 3) - 3 * t) / points.Length);
        return (float) 0.9 * z;
    }
}