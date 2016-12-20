using UnityEngine;
using System.Collections;

public class Cohete : MonoBehaviour {
	//variable publica, saldra en el editor para modificarla sin entrar a codigo, controla la fuerza del salto

	public float aceleracion = 10f;
	public float fuerza = 10f;
	public float fuerzaLateral = 100f;


	// Update is called once per frame
	void Update () { 
		//Si pulso la tecla Espacio

			//Muestrame en consola Espacio Pulsado
			
			//Le decimos al rigibody que tengamos fuerza en el transform multiplcando la variable fuerza
		GetComponent<Rigidbody2D> ().AddForce (transform.up*aceleracion);

		//Pulso la tecla flecha derecha y gira por frame
		if(Input.GetKey(KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (transform.right*fuerza);
		}

		if(Input.GetKey(KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().AddForce (transform.right*-fuerza);
		}
	}

	public void izquierda(){
		GetComponent<Rigidbody2D> ().AddForce (transform.right*-fuerzaLateral);
	}

	public void derecha(){
		GetComponent<Rigidbody2D> ().AddForce (transform.right*fuerzaLateral);
	}


}
