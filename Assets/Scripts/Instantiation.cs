using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public Transform brick;

    public Transform playerC;

    //public ArrayList<Vector3> points = new ArrayList<Vector3>(); 
    //public Transform[] wayPoints = new Transform[100];
    private const int PUNKTMENGE = 360;
    public int stretch = 15;
    public float density_factor = 0.5f;
    public Vector3[] points = new Vector3[PUNKTMENGE];

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        GameObject plane = GameObject.FindGameObjectWithTag("Boden");
        
        for (int x = 0; x < points.Length; x++)
        {
            Instantiate(brick, new Vector3(FvonT(x), plane.transform.position.y + 0.2f, GvonT(x)), Quaternion.identity);
            Instantiate(brick, new Vector3( 0.97f * FvonT(x), plane.transform.position.y + 0.2f ,  0.97f * GvonT(x)), Quaternion.identity);
            Vector3 posVector = new Vector3((float) 0.99 * FvonT(x), plane.transform.position.y + 0.2f, (float) 0.99 * GvonT(x));
            points[x] = posVector;
            Instantiate(playerC, posVector, Quaternion.identity);
        }
    }


    void Start()
    {
    }

    float FvonT(float t)
    {
        float x = (stretch * Mathf.Cos(2 * Mathf.PI / points.Length * t));
        return x;
    }

    float GvonT(float t)
    {
        float z = (stretch * Mathf.Sin(2 * Mathf.PI / points.Length * t));
        return z;
    }
}