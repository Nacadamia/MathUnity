using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spiral_Scene : MonoBehaviour
{

    public string sceneName;

    // Use this for initialization
    void Start()
    {
        SceneManager.LoadScene(sceneName);
    }


}
