using UnityEngine;
using System.Collections;

public class Algo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Touch dedito = Input.GetTouch (0);

		//Vector2 pos = dedito.position;
		this.gameObject.transform.position=dedito.position;


	
	}
}
