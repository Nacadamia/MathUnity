using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Instantiation_Spiral : MonoBehaviour
{
    public Transform brick;
    public Transform playerC;
    private const int PUNKTMENGE = 360;
    public Vector3[] points = new Vector3[PUNKTMENGE];
    
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        GameObject plane = GameObject.FindWithTag("Boden");
        
        for (int x = 0; x < points.Length; x++)
        {
            Instantiate(brick, new Vector3(FvonT(x), plane.transform.position.y + 0.1f, GvonT(x)), Quaternion.identity);
            Vector3 posVector = new Vector3((float) FvonT(x), 1, (float) GvonT(x));
            points[x] = posVector ;
            
            Instantiate(playerC, posVector, Quaternion.identity);
        }
    }

    void Start()
    {
    }

    float FvonT(float t)
    {
        float x = (t  * (Mathf.Cos(2 * Mathf.PI / points.Length * t)));
        return (float) 0.1 * x;
    }

    float GvonT(float t)
    {
        float z = (t  * (Mathf.Sin(2 * Mathf.PI / points.Length * t)));
        return (float)0.1 * z;
    }

}