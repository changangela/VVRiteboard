using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
	public static float PLAYER_SPEED = 1;
	public static float PLAYER_FATNESS = 25;
	public enum PlayerZone {
		WALKING,
		CONFIRM_MENU,
		SELECTION,
		DRAWING
	};

	public PlayerZone zone = PlayerZone.WALKING;

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
			if (zone == PlayerZone.WALKING) {
				transform.position = transform.position + new Vector3(transform.forward.x * PLAYER_SPEED, 0, transform.forward.z * PLAYER_SPEED);
				if (transform.position.x < PLAYER_FATNESS) {
		  			transform.position = new Vector3(PLAYER_FATNESS, transform.position.y, transform.position.z);
		  			zone = PlayerZone.CONFIRM_MENU;
		  		} else if (transform.position.x > Room.transform.localScale.x / 2 - PLAYER_FATNESS) {
		  			transform.position = new Vector3(Room.transform.localScale.x / 2 - PLAYER_FATNESS, transform.position.y, transform.position.z);
		  			zone = PlayerZone.CONFIRM_MENU;
		  		}
		  		if (transform.position.z < PLAYER_FATNESS) {
		  			transform.position = new Vector3(transform.position.x, transform.position.y, PLAYER_FATNESS);
		  			zone = PlayerZone.CONFIRM_MENU;
		  		} else if (transform.position.z > Room.transform.localScale.z / 2 - PLAYER_FATNESS) {
		  			transform.position = new Vector3(transform.position.x, transform.position.y, Room.transform.localScale.z / 2 - PLAYER_FATNESS);
		  			zone = PlayerZone.CONFIRM_MENU;
		  		}
			}
	  	}

	  	if (zone == PlayerZone.CONFIRM_MENU) {
	  		float MENU_DIST = 3f;
			GameObject menu = GameObject.Find("ConfirmMenu");
			menu.transform.position = transform.position + new Vector3(transform.forward.x, 0, transform.forward.z) * MENU_DIST;
			menu.transform.forward = new Vector3(transform.forward.x, 0, transform.forward.z);
	  	}
  		
	}
}
