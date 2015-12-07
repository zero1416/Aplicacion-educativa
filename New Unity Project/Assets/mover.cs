﻿using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public LineRenderer lineRender;
	private int numberOfPoints = 0;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Touch dedito= Input.GetTouch (0);

		if (Input.touchCount == 1) {
			Vector2 worlpos=Camera.main.ScreenToWorldPoint(dedito.position);
			transform.position=worlpos;
		}

	
	}
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Moneda1")
		{
			if (Input.GetKey (KeyCode.Mouse0)) {
				numberOfPoints++;
				lineRender.SetVertexCount (numberOfPoints);
				Vector3 mousePos = new Vector3 (0, 0, 0);
				mousePos = Input.mousePosition;
				mousePos.z = 1.0f;
				Vector3 worldPos = Camera.main.ScreenToWorldPoint (mousePos);
				lineRender.SetPosition (numberOfPoints - 1, worldPos);
			} else {
				numberOfPoints = 0;
				lineRender.SetVertexCount (0);
			}

		}
		if (col.gameObject.name == "Moneda2") {
			Debug.Log(col.gameObject.name);
		}
	}
}
