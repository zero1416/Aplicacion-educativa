﻿using UnityEngine;
using System.Collections;

public class Algo : MonoBehaviour {

	public LineRenderer lineRender;
	private int numberOfPoints = 0;
	int patron;

	public GameObject nodo1, nodo2 , nodo3, nodo4, nodo5;

	// Use this for initialization
	void Start () {
		Screen.SetResolution (720, 1280, true);
		patron = 1;
	
	}
	
	// Update is called once per frame
	void Update () {

		/*if (nodo1.GetComponent<Moneda1> ().pressed == true && patron == 1) {

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
		}*/


	
	}
}
