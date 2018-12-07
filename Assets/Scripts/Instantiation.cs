﻿using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public Transform brick;

    public Transform playerC;

    //public ArrayList<Vector3> points = new ArrayList<Vector3>(); 
    //public Transform[] wayPoints = new Transform[100];
    private const int PUNKTMENGE = 100;
    public Vector3[] points = new Vector3[PUNKTMENGE];

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        for (int x = 0; x < points.Length; x++)
        {
            Instantiate(brick, new Vector3(FvonT(x), 1, GvonT(x)), Quaternion.identity);
            Instantiate(brick, new Vector3(FvonT_inner(x), 1, GvonT_inner(x)), Quaternion.identity);
            Vector3 posVector = new Vector3((float) 0.95 * FvonT(x), 1, (float) 0.95 * GvonT(x));
            points[x] = posVector;
            Instantiate(playerC, posVector, Quaternion.identity);
        }
    }


    void Start()
    {
    }

    float FvonT(float t)
    {
        float x = (50 * Mathf.Cos(2 * Mathf.PI / points.Length * t));
        return x;
    }

    float FvonT_inner(float t)
    {
        float x = (50 * Mathf.Cos(2 * Mathf.PI / points.Length * t));
        return (float) 0.9 * x;
    }

    float GvonT(float t)
    {
        float z = (50 * Mathf.Sin(2 * Mathf.PI / points.Length * t));
        return z;
    }

    float GvonT_inner(float t)
    {
        float z = (50 * Mathf.Sin(2 * Mathf.PI / points.Length * t));
        return (float) 0.9 * z;
    }
}