using UnityEngine;
using System.Collections;

public class Coche : MonoBehaviour {
	// Definimos una variable para meter dentro el componente WheelJoint2D
	WheelJoint2D union_rueda; 

	void Start () {
		//Metemos la información del componente WheelJoint2D en la variable
		union_rueda = GetComponent<WheelJoint2D> ();
	}

	void Update () {
		// Vemos si pulsamos la tecla espacio
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Cambiamos el valor de la variable useMotor al contrario de su valor
			union_rueda.useMotor = !union_rueda.useMotor;
		}
	}
}