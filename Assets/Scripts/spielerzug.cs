using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spielerzug : MonoBehaviour {

	public Transform playerC;


	// Use this for initialization
	void Start () {
		
for (int x = 0; x < 60; x++) 
        {
			float dx = (fvont(x) - fvont_inner(x));
			float pz = (gvont(x) - gvont_inner(x));
			float d = Mathf.Sqrt((Mathf.Pow(dx,2) + Mathf.Pow(pz,2)));
		
            Instantiate(playerC, new Vector3((float)0.95 * fvont(x), 1, (float) 0.95 * gvont(x)), Quaternion.identity);
		
        }

 }

 float fvont(float t){
	float x = (50 * Mathf.Cos(2 * Mathf.PI/60 * t));
	return x;
 }

float fvont_inner(float t){
	float x = (50 * Mathf.Cos(2 * Mathf.PI/60 * t));
	return (float) 0.9 * x;
 }

 float gvont(float t){
	 float z = (50 * Mathf.Sin(2*Mathf.PI/60 * t));
	return z;
}

float gvont_inner(float t){
	float z = (50 * Mathf.Sin(2*Mathf.PI/60 * t));
	return (float) 0.9 * z;
}



	}
	
