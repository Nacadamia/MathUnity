using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class movement : MonoBehaviour
{
    public Transform target;
    public int x = 0;
    public float speed = 0.5f;
    public GameObject[] playerC;
    public GameObject[] wayPoints;
    public GameObject Player;
    public float naeherung = 0.10f;


    void Awake()
    {
        Player = GameObject.Find("Player");
        playerC = GameObject.FindGameObjectsWithTag("waypoint");

        if (playerC.Length > 0)
        {
            target = playerC[0].transform;
        }

        else
        {
            Debug.Log("Leere Liste");
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


        transform.LookAt(target.position);
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);


        if (Vector3.Distance(transform.position, target.position) < naeherung)
        {
            target.position = playerC[x].transform.position;
            if (x >= playerC.Length - 1) x = 0;
            else
                x++;
        }
    }

    void init_player_pos()
    {
        if (playerC != null && playerC.Length > 0)
            this.transform.position = playerC[0].transform.position;
    }
}