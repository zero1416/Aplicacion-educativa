using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {

	public LineRenderer lineRender;
	private int numberOfPoints = 0;
	public GameObject nodo3;
	bool nodo1, nodo2, nodoo3, ganar;



	// Use this for initialization
	void Start () {
		nodo1 = false;
		nodo2 = false;
		nodoo3 = false;
		ganar = false;
	}
	
	// Update is called once per frame
	void Update () {

		Touch dedito= Input.GetTouch (0);

		if (Input.touchCount == 1) {
			Vector2 worlpos=Camera.main.ScreenToWorldPoint(dedito.position);
			transform.position=worlpos;
		}
		switch(dedito.phase){
			case TouchPhase.Began:

			break;
			case TouchPhase.Moved:
			if (nodo1 == true) {
				if (Input.GetKey (KeyCode.Mouse0)) {
					numberOfPoints++;
					lineRender.SetVertexCount (numberOfPoints);
					Vector3 mousePos = new Vector3 (0, 0, 0);
					mousePos = Input.mousePosition;
					mousePos.z = 1.0f;
					Vector3 worldPos = Camera.main.ScreenToWorldPoint (mousePos);
					lineRender.SetPosition (numberOfPoints - 1, worldPos);
				}
				if(nodo1 == true && nodo2 == true)
				{
					nodo3.SetActive(true);
				}
				
			}
			break;
			case TouchPhase.Ended:
				if(nodo1== false || nodo2== false)
				{
					numberOfPoints = 0;
					lineRender.SetVertexCount (0);
				}
				if( nodo1== true && nodo2== true && nodoo3== true)
				{
				ganar= true;
				this.transform.
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
			nodoo3= true;
		}

	}
	void OnTriggerExit2D(Collider2D col)
	{

	}
}
