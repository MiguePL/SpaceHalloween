﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Rigidbody2D rb_bomba;

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player") {
			rb_bomba.isKinematic = false;
		}

	}
		
}