using UnityEngine;
using System.Collections;

public class SaltoPollo : MonoBehaviour {
	public float fuerza = 100f;
	
	// Update is called once per frame
	void Update () {
		// Si pulso la tecla espacio
		if(Input.GetKeyDown(KeyCode.Space)){
			// Mostrar mensaje en consola
			Debug.Log("Espacio Pulsado");
		GetComponent<Rigidbody2D> ().AddForce (Vector2.up*fuerza);
	
		}
	}
}