using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Graph_Scene : MonoBehaviour
{

    public string sceneName;

    // Sobald das Script aktiv wird, wechselt die Szene 
    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }


}
