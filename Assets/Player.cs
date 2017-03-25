using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
	public static float PLAYER_SPEED = 1;

	// Use this for initialization
	void Start () {
		Debug.Log("Successfully loaded whiteboard...");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {  
	  		transform.position = transform.position + new Vector3(transform.forward.x * PLAYER_SPEED, 0, transform.forward.z * PLAYER_SPEED);
	  	}
	}
}
