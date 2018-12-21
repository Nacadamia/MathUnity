using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spiral_Scene : MonoBehaviour
{

    public string sceneName;

    // Sobald das Script aktiv wird wehcselt die Szene
    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }


}
