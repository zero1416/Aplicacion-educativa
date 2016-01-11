﻿using UnityEngine;
using System.Collections;

public class l : MonoBehaviour {
	
	public LineRenderer lineRender;
	private int numberOfPoints = 0;
	public GameObject n1, n2, win, menu, next;
	bool figura, ganar;
	bool nodo1, nodo2;
	int c;
	Vector2 mp, np;
	Vector2 posinit;
	
	// Use this for initialization
	void Start () {
		figura = false;
		ganar = false;
		nodo1 = false;
		nodo2 = false;
		c = 0;
		
		mp = new Vector2 (-1f, -0.5f);
		np = new Vector2 (1f, -0.5f);
		posinit = new Vector2 (0f,4f);
		this.transform.position = posinit;
		
	}
	
	// Update is called once per frame
	void Update () {
		Touch dedito= Input.GetTouch (0);
		if (Input.touchCount == 1) {
			Vector2 worlpos=Camera.main.ScreenToWorldPoint(dedito.position);
			transform.position=worlpos;
		}
		if (Input.GetKey (KeyCode.Mouse0)&& figura == true && ganar == false && nodo1 == true) {
			numberOfPoints++;
			lineRender.SetVertexCount (numberOfPoints);
			Vector3 mousePos = new Vector3 (0, 0, 0);
			mousePos = Input.mousePosition;
			mousePos.z = 1.0f;
			Vector3 worldPos = Camera.main.ScreenToWorldPoint (mousePos);
			lineRender.SetPosition (numberOfPoints - 1, worldPos);
		}
		if (figura == false) {
			numberOfPoints = 0;
			lineRender.SetVertexCount (0);
		}
		if (nodo1 == true) {
			n2.SetActive(true);
			if(nodo2 == true)
			{
				ganar= true;				
			}
		}
		if (ganar == true && c == 0) {
			win.SetActive(true);
			win.GetComponent<AudioSource>().Play();
			menu.transform.position = mp;
			next.transform.position = np;
			c=1;
		}
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "Figura") {
			figura = true;
		}
		if (col.gameObject.name == "Nodo1") {
			nodo1= true;
		}
		if (col.gameObject.name == "Nodo2") {
			nodo2 = true;
		}
		
		if (col.gameObject.name == "Menu") {
			Application.LoadLevel("Seleccionar");
		}
		if (col.gameObject.name == "Next") {
			Application.LoadLevel("i");
		}
		if (col.gameObject.name == "Mayusculas") {
			Application.LoadLevel("Letras");
		}
		
	}
	
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name == "Figura") {
			figura=false;
		}
	}
}