using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Circle_Scene : MonoBehaviour {

    public string sceneName;

//Bei Aktivierung wird die Szene gewechselt
	void Start () {
        SceneManager.LoadScene(sceneName);		
	}
	
	
}
