using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //Para que se pueda cambiar de escena

public class RestartEnemigo : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D objeto){
		if(objeto.tag == "Player"){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

	}
}
