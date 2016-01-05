using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public LineRenderer lineRender;
	private int numberOfPoints = 0;
	public GameObject gnodo1,gnodo2,gnodo3,gnodo4, win, Bm, Bs;
	public GameObject gguia1, gguia2, gguia3, gguia4;
	Vector3 PosBm, PosBs;
	bool nodo1, nodo2, nodo3, nodo4, ganar; 
	bool guia1, guia2, guia3, guia4;
	int c;



	// Use this for initialization
	void Start () {
		nodo1 = false;
		nodo2 = false;
		nodo3 = false;
		nodo4 = false;
		ganar = false;
		guia1 = false;
		guia2 = false;
		guia3 = false;
		guia4 = false;
		PosBm = new Vector3 (-1.0f, -0.8f, 0f);
		PosBs = new Vector3 (1.0f, -0.8f, 0f);
		c = 0;
	}
	
	// Update is called once per frame
	void Update () {

		Touch dedito= Input.GetTouch (0);

		if (Input.touchCount == 1) {
			Vector2 worlpos=Camera.main.ScreenToWorldPoint(dedito.position);
			transform.position=worlpos;
		}
		if (nodo1 == true && nodo2 == true && nodo3 == true && nodo4 == true&& numberOfPoints!=100) {

			ganar= true;
			if(ganar==true && c==0)
			{
			win.SetActive(true);
				Bm.transform.position=Camera.main.ScreenToWorldPoint(PosBm);
				Bs.transform.position=Camera.main.ScreenToWorldPoint(PosBs);
			win.GetComponent<AudioSource>().Play();

			c=1;
			}
		}

		switch(dedito.phase){
			case TouchPhase.Began:



			break;
			case TouchPhase.Moved:
			if(nodo1 == true && ganar== false) {

				if (Input.GetKey (KeyCode.Mouse0)) {
					numberOfPoints++;
					lineRender.SetVertexCount (numberOfPoints);
					Vector3 mousePos = new Vector3 (0, 0, 0);
					mousePos = Input.mousePosition;
					mousePos.z = 1.0f;
					Vector3 worldPos = Camera.main.ScreenToWorldPoint (mousePos);
					lineRender.SetPosition (numberOfPoints - 1, worldPos);
				}
				if(nodo2 == true && nodo1 == true)
				{
					gnodo3.SetActive(true);
					if(nodo3 == true)
					{
						gnodo4.SetActive(true);
					}
				}

				if ( nodo1 == true)
				{
					gguia1.SetActive(true);
					if( nodo2 == true)
					{
						gguia2.SetActive(true);
						if(nodo3 == true)
						{
							gguia3.SetActive(true);
							if(nodo4 == true)
							{
								gguia4.SetActive(true);
							}
						}
					}
				}

				if(nodo1 == false)
				{
					nodo2= false;
					nodo3= false ;
					nodo4= false ;
					guia1=false ;
					guia2=false;
					guia3=false;
					guia4=false;
				}
				
			}
			break;
			case TouchPhase.Ended:
			if(nodo2 == false|| nodo3 == false || nodo4 == false)
				{
					numberOfPoints = 0;
					lineRender.SetVertexCount (0);
				}


			break;

		}
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{

		if (col.gameObject.name == "Moneda1") {
			nodo1 = true;
		}
		if (col.gameObject.name == "guia1") {
				guia1 = true;
		}
		if (col.gameObject.name == "Moneda2") {
				nodo2 = true;
		}
		if (col.gameObject.name == "guia2") {
				guia2 = true;
		}
		if (col.gameObject.name == "Moneda3") {
				nodo3 = true;
		}
		if (col.gameObject.name == "guia3") {
				guia3 = true;
		}
		if (col.gameObject.name == "Moneda4") {
				nodo4 = true;
		}
		if (col.gameObject.name == "guia4") {
				guia4 = true;
		}
		if (col.gameObject.name == "Menu") {
			Application.LoadLevel("Seleccionar");
		}


	}
	void OnTriggerExit2D(Collider2D col)
	{
		/*if(col.gameObject.name != "Moneda1") {
			nodo2= false;
			nodo3= false ;
			nodo4= false ;
			guia1=false ;
			guia2=false;
			guia3=false;
			guia4=false;
		}*/
		if (col.gameObject.name == "guia1") {
			if(guia2!=true)
			{
			numberOfPoints = 0;
			lineRender.SetVertexCount (0);
			}
		}
		if (col.gameObject.name == "guia2") {
			if(guia3!=true)
			{
				numberOfPoints = 0;
				lineRender.SetVertexCount (0);
			}
		}
		if (col.gameObject.name == "guia3") {
			if(guia4!=true)
			{
				numberOfPoints = 0;
				lineRender.SetVertexCount (0);
			}
		}



	}
}
