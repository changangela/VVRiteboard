using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
	private float SPEED = 1;

	// Use this for initialization
	void Start () {
		Debug.Log("Successfully loaded whiteboard...");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {  
	  		transform.position = transform.position + transform.forward * SPEED;
	  	}
	}
}
