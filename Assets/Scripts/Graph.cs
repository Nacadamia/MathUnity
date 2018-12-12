﻿using UnityEngine;

public class Graph : MonoBehaviour {

	public Transform pointPrefab;
    public float Stauchung = 0.01f; 
    private int a = 1;

	[Range(10, 100)]
	public int resolution = 100;

	Transform[] points;

	void Awake () {
		float step = 2f / resolution;
		Vector3 scale = Vector3.one * step;
		Vector3 position;
		position.y = 0f;
		position.z = 0f;
		points = new Transform[resolution];
		for (int i = 0; i < points.Length; i++) {
			Transform point = Instantiate(pointPrefab);
            //position.x = (i + 0.5f) * step - 1f;

            position.x = Mathf.Pow(i, 2) * Stauchung;

            point.localPosition = position;
			point.localScale = scale;
			point.SetParent(transform, false);
			points[i] = point;
		}
	}

	void Update () {
		for (int i = 0; i < points.Length; i++) {
			Transform point = points[i];
			Vector3 position = point.localPosition;
            position.y = (Mathf.Pow(i, 3) * a) * Stauchung; //Mathf.PI * (position.x + Time.time));
			point.localPosition = position;
		}
	}
}