using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Importante para que funionen el UI
using UnityEngine.SceneManagement; //Para que se pueda cambiar de escena

public class CronometroAtras : MonoBehaviour {

	public float tiempo =20;
	public Text texto;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		tiempo -= Time.deltaTime;
		texto.text = ""+Mathf.Round(tiempo);

		if(tiempo<=0){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}



}