using UnityEngine;
using System.Collections;

public class Compuerta : MonoBehaviour {

	public HingeJoint2D compuerta;

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			compuerta.useMotor = true;
		}

	}

    void OnTriggerExit2D(Collider2D objeto){
        if (objeto.tag == "Player") {
            compuerta.useMotor = false;
        }

    }
}