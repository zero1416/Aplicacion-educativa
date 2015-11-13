using UnityEngine;
using System.Collections;

public class Cclick : MonoBehaviour {

	// Use this for initialization
	public int Patron=1;
	public GameObject mon1, mon2, mon3 ;
	public GameObject barra1;
	Vector3 Vact, Vant;


	void Start () {
		Screen.SetResolution (720, 1280, true);
	}
	
	// Update is called once per frame
	void Update () {



		if (mon1.GetComponent<Moneda1> ().pressed == true && Patron == 1) {
			Vant=Vact;
			Vact = Input.mousePosition;

			if(Vact.y<Vant.y)
			{
				Vector3 aux = barra1.transform.position;
				aux.z-=0.03f;
				barra1.transform.position = aux;
			}
			//this.Patron++;
			//mon1.GetComponent<Moneda1> ().pressed = false;

		} 
		if (mon1.GetComponent<Moneda1> ().pressed == true && Patron != 1) {
			//mon1.GetComponent<>()
			mon1.GetComponent<Moneda1> ().pressed = false;
			Debug.Log("moneda1 incorrecto");
		}
		if (mon2.GetComponent<Moneda2> ().pressed == true && Patron == 2) {


			this.Patron++;
			mon2.GetComponent<Moneda2> ().pressed = false; 
			Debug.Log("moneda2 correcto");
		} 
		if (mon2.GetComponent<Moneda2> ().pressed == true && Patron != 2) {
			mon2.GetComponent<Moneda2> ().pressed = false;			
			Debug.Log("moneda2 incorrecto");
		}
		if (mon3.GetComponent<Moneda3> ().pressed == true && Patron == 3) {
			this.Patron++;
			mon3.GetComponent<Moneda3> ().pressed = false;			
			Debug.Log("moneda3 correcto");
		} 
		if (mon3.GetComponent<Moneda3> ().pressed == true && Patron != 3) {
			mon3.GetComponent<Moneda3> ().pressed = false;
			Debug.Log("moneda3 incorrecto");
		}

	}
}
