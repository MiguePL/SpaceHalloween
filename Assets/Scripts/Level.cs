using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;	//Importante para poder modificar escenas

public class Level : MonoBehaviour{
	public int nivel;


	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("Algo se ha tocado");
		if (col.tag == "Player") {
			SceneManager.LoadScene (nivel);
		}
	}
}


	
