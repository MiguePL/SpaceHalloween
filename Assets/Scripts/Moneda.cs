using UnityEngine;
using System.Collections;

public class Moneda : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("Algo se ha tocado");
		if (col.tag == "Player") {
		Destroy (gameObject);
		}
	}
}
