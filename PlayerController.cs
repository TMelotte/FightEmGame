﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;
	public float rotationSpeed = 100.0f;

	private int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);
		}

	//FixedUpdate is called when phyisics calculations will be done
	void FixedUpdate(){
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Enemy")) {
			Destroy (other.gameObject);
			count++;
		}
	}
}
