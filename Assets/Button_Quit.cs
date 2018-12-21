using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Quit : MonoBehaviour {

	
    public void Start()
    {
        //Im Build 
     #if UNITY_STANDALONE //Meta Tag für den Interpreter
        //Beenden der Anwendung
        Application.Quit();
    #endif

        //Damit es auch im Editor funktioniert
    #if UNITY_EDITOR
        //Beenden der Application 
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }

}
