using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class movement : MonoBehaviour
{
    public Transform target;
    public int x = 0;
    public float speed = 0.5f;
    private GameObject[] playerC;
    public GameObject[] wayPoints;
    public GameObject Player;
    public float naeherung = 0.01f;


    void Awake()
    {
        //Player Objekt finden
        Player = GameObject.Find("Player");
        //Wegpunkte anhand ihrer tags finden
        playerC = GameObject.FindGameObjectsWithTag("waypoint");

        if (playerC.Length > 0)
        {
            target = playerC[0].transform; //Ziel ist der Positionsvektor
        }

        else
        {
            Debug.Log("Leere Liste"); // Geschieht in der Regel, wenn die Prefabs im Editor nicht zugeornet sind, oder keinen Tag haben
        }

        init_player_pos();

        if (x >= playerC.Length - 1) x = 0;
    }

    void Start()
    {
    }

    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;


        //  transform.LookAt(target.position); //<--- alte, ruckelige Methode
        
        //Neue weiche Methode, Rotieren des Spielers über Zeit 
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(target.position), Time.deltaTime * speed);
        //Bewegung des Sipelers über Zeit 
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        //Wenn der Spieler nahe genug an einem Punkt ist, wird der nächste angesteuert. Im Grunde ein epsilon für die Näherung
        if (Vector3.Distance(transform.position, target.position) < naeherung)
        {
            target.position = playerC[x].transform.position;
            if (x >= playerC.Length - 1) x = 0;
            else
                x++;
        }
    }
    
    //Intitialisierung der Player Position
    void init_player_pos()
    {
        if (playerC != null && playerC.Length > 0)
            this.transform.position = playerC[0].transform.position;
    }
}