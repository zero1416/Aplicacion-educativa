using UnityEngine;
using System.Collections;

public class Prueba : MonoBehaviour {

	public LineRenderer lineRender;
	private int numberOfPoints = 0;
	bool tocar, nodo1, ganar;

	// Use this for initialization
	void Start () {
		tocar = false;
		nodo1 = false;
	}
	
	// Update is called once per frame
	void Update () {
		Touch dedito= Input.GetTouch (0);
		if (Input.touchCount == 1) {
			Vector2 worlpos=Camera.main.ScreenToWorldPoint(dedito.position);
			transform.position=worlpos;
		}
		if (Input.GetKey (KeyCode.Mouse0) && tocar == true && nodo1 == true) {
			numberOfPoints++;
			lineRender.SetVertexCount (numberOfPoints);
			Vector3 mousePos = new Vector3 (0, 0, 0);
			mousePos = Input.mousePosition;
			mousePos.z = 1.0f;
			Vector3 worldPos = Camera.main.ScreenToWorldPoint (mousePos);
			lineRender.SetPosition (numberOfPoints - 1, worldPos);
		}
		if (tocar == false) {
			numberOfPoints = 0;
			lineRender.SetVertexCount (0);
		}
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name == "cero") {
			tocar = true;
		}
		if (col.gameObject.name == "Nodo1") {
			nodo1 = true;
		}
		if (col.gameObject.name == "Menu")
		{
			Application.LoadLevel("Seleccionar");
		}
	}
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.name == "cero") {
			tocar = false ;
		}
	}
}
