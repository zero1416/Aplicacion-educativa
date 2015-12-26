using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public LineRenderer lineRender;
	private int numberOfPoints = 0;
	public GameObject gnodo1,gnodo2,gnodo3, win1, win2;
	bool nodo1, nodo2, nodoo3, ganar, guia1, guia2;



	// Use this for initialization
	void Start () {
		nodo1 = false;
		nodo2 = false;
		nodoo3 = false;
		ganar = false;
		guia1 = false;
		guia2 = false;
	}
	
	// Update is called once per frame
	void Update () {

		Touch dedito= Input.GetTouch (0);

		if (Input.touchCount == 1) {
			Vector2 worlpos=Camera.main.ScreenToWorldPoint(dedito.position);
			transform.position=worlpos;
		}
		if (nodo1 == true && nodo2 == true && nodoo3 == true && numberOfPoints!=0) {

			ganar= true;
			win1.SetActive(true);
			win2.SetActive(true);
			win1.GetComponent<AudioSource>().Play();
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
				if(nodo2== true&& nodo1== true)
				{
					gnodo3.SetActive(true);
				}
				
			}
			break;
			case TouchPhase.Ended:
			if(nodo2 == false|| nodoo3== false)
				{
					numberOfPoints = 0;
					lineRender.SetVertexCount (0);
				}


			break;

		}
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		Debug.Log ("tocando 2d");
		if (col.gameObject.name == "Moneda1") {
			nodo1 = true;
			}
		if (col.gameObject.name == "Moneda2") {
			nodo2 = true;
		} 
		if (col.gameObject.name == "Moneda3") {
			nodoo3 = true;
		}
		if (col.gameObject.name == "guia1") {
			guia1 = true;
		}
		if (col.gameObject.name == "guia2") {
			guia2 = true;
		} 

	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (nodo1 == false) {
		if(col.gameObject.name == "Moneda2"){
				nodo2=false ;
			}
			if(col.gameObject.name=="guia1")
			{
				guia1= false;
			}
		}
		if (col.gameObject.name == "guia1") {
			if(guia2!=true)
			{
			numberOfPoints = 0;
			lineRender.SetVertexCount (0);
			}
		}

	}
}
