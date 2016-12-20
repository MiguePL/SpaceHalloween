using UnityEngine;
using System.Collections;

public class Puerta : MonoBehaviour {
	HingeJoint2D bisagra;
	JointMotor2D motor;


	// Use this for initialization
	void Start () {
		bisagra = GetComponent <HingeJoint2D> ();
		motor = bisagra.motor;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.T)) {
			bisagra.useMotor = true;
		}

		if (Input.GetKeyUp	(KeyCode.T)) {
			bisagra.useMotor = false;
		}	
	}

}