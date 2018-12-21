using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public Transform brick;

    public Transform playerC;
    
    private const int PUNKTMENGE = 360;
    private int stretch = 15;
    private Vector3[] points = new Vector3[PUNKTMENGE];

    /// <summary>
    /// Bei der Instantiierung des Objekts wird die Awake Methode aufgerufen und die Prefabs in der Scene aufgebaut. 
    /// </summary>
    void Awake()
    {
        GameObject plane = GameObject.FindGameObjectWithTag("Boden"); //Boden suchen
        
        for (int x = 0; x < points.Length; x++)
        {
            //Äußerer Kreis
            Instantiate(brick, new Vector3(FvonT(x), plane.transform.position.y + 0.2f, GvonT(x)), Quaternion.identity);
            //Innerer Kreis
            Instantiate(brick, new Vector3( 0.97f * FvonT(x), plane.transform.position.y + 0.2f ,  0.97f * GvonT(x)), Quaternion.identity);
            //Positionen der Pfadanimantion
            Vector3 posVector = new Vector3((float) 0.99 * FvonT(x), plane.transform.position.y + 0.2f, (float) 0.99 * GvonT(x));
            //Positionen abspeichern
            points[x] = posVector;
            //Erzeugen der Player Koordinaten
            Instantiate(playerC, posVector, Quaternion.identity);
        }
    }


    void Start()
    {
    }
    // f(t)
    float FvonT(float t)
    {
        float x = (stretch * Mathf.Cos(2 * Mathf.PI / points.Length * t));
        return x;
    }
    // g(t)
    float GvonT(float t)
    {
        float z = (stretch * Mathf.Sin(2 * Mathf.PI / points.Length * t));
        return z;
    }
}