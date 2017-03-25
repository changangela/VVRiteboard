using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
	public static float PLAYER_SPEED = 1;
	public static float PLAYER_FATNESS = 25;
	public GameObject Room;
	// Use this for initialization
	void Start () {
		Debug.Log("Successfully loaded whiteboard...");
		Room = GameObject.Find("Room");
		Debug.Log(Room.transform.localScale.x);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {  
	  		transform.position = transform.position + new Vector3(transform.forward.x * PLAYER_SPEED, 0, transform.forward.z * PLAYER_SPEED);
	  	}
  		if (transform.position.x < PLAYER_FATNESS) {
  			transform.position = new Vector3(PLAYER_FATNESS, transform.position.y, transform.position.z);
  		} else if (transform.position.x > Room.transform.localScale.x / 2 - PLAYER_FATNESS) {
  			transform.position = new Vector3(Room.transform.localScale.x / 2 - PLAYER_FATNESS, transform.position.y, transform.position.z);
  		}
  		if (transform.position.z < PLAYER_FATNESS) {
  			transform.position = new Vector3(transform.position.x, transform.position.y, PLAYER_FATNESS);
  		} else if (transform.position.z > Room.transform.localScale.z / 2 - PLAYER_FATNESS) {
  			transform.position = new Vector3(transform.position.x, transform.position.y, Room.transform.localScale.z / 2 - PLAYER_FATNESS);
  		}
	}
}
