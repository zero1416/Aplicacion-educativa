using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay (Collider col) {
		Debug.Log ("hola");
	}
}
