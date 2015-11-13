using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.SetResolution (720, 1280, true);
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	// primer menu
	public void Iniciar()
	{
		Application.LoadLevel ("Seleccionar");
	}
	public void Salir()
	{
		Application.Quit ();
	}

	// segundo menu

	public void Letras()
	{
		Application.LoadLevel ("Letras");
	}
	public void Numeros()
	{
		Application.LoadLevel ("Numeros");
	}
	public void Figuras()
	{
		Application.LoadLevel ("Figuras");
	}
	public void Opciones()
	{
		Application.LoadLevel ("Opciones");
	}
	public void Seleccionar()
	{
		Application.LoadLevel ("Seleccionar");
	}

}
