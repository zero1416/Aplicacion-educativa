using UnityEngine;
using System.Collections;

public class ControI : MonoBehaviour {

	public GameObject img1, img2, img3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	 void Update () {

		Destroy (img3, 3);
		Destroy (img2, 6);
		Destroy (img1, 9);

	}
	void OnMouseDown()
	{
		Application.LoadLevel ("Seleccionar");
	}
	
}
