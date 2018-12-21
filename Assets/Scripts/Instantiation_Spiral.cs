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
    /// Bei der Instantiierung des Objekts wird die Awake Methode aufgerufen und die Prefabs in der Scene aufgebaut. 
    /// </summary>
    void Awake()
    {
        GameObject plane = GameObject.FindWithTag("Boden");
        
        for (int x = 0; x < points.Length; x++)
        {
            //Erzeugen der Flats
            Instantiate(brick, new Vector3(FvonT(x), plane.transform.position.y + 0.1f, GvonT(x)), Quaternion.identity);
            //Positionen für die Pfadanimation
            Vector3 posVector = new Vector3((float) FvonT(x), 1, (float) GvonT(x));
            points[x] = posVector ;
            //PlayerC Objekte für die Animation erzeugen
            Instantiate(playerC, posVector, Quaternion.identity);
        }
    }

    void Start()
    {
    }

     //f(t)
    float FvonT(float t)
    {
        float x = (t  * (Mathf.Cos(2 * Mathf.PI / points.Length * t)));
        return (float) 0.1 * x;
    }
     //g(t)
    float GvonT(float t)
    {
        float z = (t  * (Mathf.Sin(2 * Mathf.PI / points.Length * t)));
        return (float)0.1 * z;
    }

}