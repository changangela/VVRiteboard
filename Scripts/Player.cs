using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
	public static float PLAYER_SPEED = 0.3f;
	public static float PLAYER_FATNESS = 25;
	public static float PEN_DIST = 15;
	public static float EPS = 10e-7f;
	public static Vector3 PLAYER_DEFAULT_POSITION = new Vector3(100, 25, 100);
	public enum PlayerZone {
		WALKING,
		SELECTION,
		DRAWING,
		ERASING,
		UNDOING
	};
	public static float MENU_DIST = 15f;

	public static PlayerZone zone = PlayerZone.WALKING;

	public static List<GameObject> spots = new List<GameObject>();
	public GameObject Room;
	public static float DRAWING_RADIUS = 2f;

	public bool faceUp = false;
	// Use this for initialization
	void Start () {
		Debug.Log("Successfully loaded whiteboard...");
		Room = GameObject.Find("Room");
		Debug.Log(Room.transform.localScale.x);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.deviceOrientation == DeviceOrientation.FaceUp) {
			if (zone != PlayerZone.SELECTION && !faceUp) {
				faceUp = true;
				zone = PlayerZone.SELECTION;

		  		GameObject pens = GameObject.Find("Pens");
		  		pens.transform.position = transform.position + new Vector3(transform.forward.x, transform.forward.y, transform.forward.z) * MENU_DIST;
				pens.transform.forward = transform.forward;

				GameObject pointer = GameObject.Find("Pointer");
		  		pointer.transform.position = transform.position + new Vector3(transform.forward.x, transform.forward.y, transform.forward.z) * MENU_DIST;
				pointer.transform.forward = transform.forward;
			}
		} else {
			faceUp = false;
		}

		if (Input.GetMouseButton(0)) {

			if (zone == PlayerZone.WALKING) {
				transform.position = transform.position + new Vector3(transform.forward.x * PLAYER_SPEED, 0, transform.forward.z * PLAYER_SPEED);
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

			if (zone == PlayerZone.DRAWING) {
				if (Input.deviceOrientation != DeviceOrientation.FaceUp || faceUp) {
					GameObject spot = GameObject.Find("Spot");
					GameObject spotClone = Instantiate(spot, transform.position + transform.forward * DRAWING_RADIUS, transform.rotation);
					spots.Add(spotClone);
				}
			}

			if (zone == PlayerZone.UNDOING) {
				GameObject tempSpot = spots[spots.Count - 1];
				spots.RemoveAt(spots.Count - 1);
				Destroy(tempSpot);
			}
	  	}

	  	if (zone == PlayerZone.SELECTION) {

	  	}

	  	if (zone == PlayerZone.DRAWING) {
	  		GameObject pointer = GameObject.Find("Pointer");
	  		pointer.transform.position = transform.position + transform.forward;
	  	}
  		
	}
}
