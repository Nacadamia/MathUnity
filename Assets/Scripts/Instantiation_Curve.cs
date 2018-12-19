using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Instantiation_Curve : MonoBehaviour
{
    
    public Transform brick;
    public Transform playerC;
    private const int PUNKTMENGE = 360;
    private Vector3[] points = new Vector3[PUNKTMENGE];

    /// <summary>
    /// Awake wird aufgerufen wenn instantiiert wird. 
    /// </summary>
    void Awake()
    {
        for (int x = 0; x < points.Length; x++)
        {
           // Instantiate(brick, new Vector3( 1, FvonT(x), GvonT(x)), Quaternion.identity);
            Instantiate(brick, new Vector3( 0.90f * FvonT(x), 0.90f * GvonT(x), x), Quaternion.identity);
            
            //Erzeugen der Wegpunkt Koordinaten
            Vector3 posVector = new Vector3( 0.90f * FvonT(x), 0.9f * GvonT(x), x);
            
            //Abspeichern der Koordinaten für die Pfadanimation
             points[x] = posVector;

            //Instantiieren der Wegpunkte für die Pfadanimation
            Instantiate(playerC, posVector, Quaternion.identity);
        }
    }


    void Start()
    {
    }

    //Funktion für die X-Koordinate
    float FvonT(float t)
    {
        float x = (Mathf.Pow(t, 2) / points.Length);
        return x;
    }
    
    //Funktion für die Z-Koordinate
    float GvonT(float t)
    {
        float z = ((Mathf.Pow(1 * t, 3) - 3 * t) / points.Length);
        return z;
    }

  
}