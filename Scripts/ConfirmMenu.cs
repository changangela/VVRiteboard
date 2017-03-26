using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;


public class ConfirmMenu : MonoBehaviour {
	public static Vector3 HIDDEN_DEFAULT_POSITION = new Vector3(10000, 0, 10000);

	public void Awake() {

	}

	public void onNo() {
		Debug.Log("Selection: no");
		GameObject player = GameObject.Find("Player");
		player.transform.position = Player.PLAYER_DEFAULT_POSITION;
		GameObject menu = GameObject.Find("ConfirmMenu");
		menu.transform.position = HIDDEN_DEFAULT_POSITION;
		Player.zone = Player.PlayerZone.WALKING;
	}

	public void onYes() {
		Debug.Log("Selection: yes");
		Player.zone = Player.PlayerZone.SELECTION;
		
		GameObject menu = GameObject.Find("ConfirmMenu");
		menu.transform.position = HIDDEN_DEFAULT_POSITION;

		GameObject player = GameObject.Find("Player");

		GameObject backButton = GameObject.Find("BackButton");
		backButton.transform.position = HIDDEN_DEFAULT_POSITION;

		GameObject room = GameObject.Find("Room");
		if ((player.transform.position.x - Player.PLAYER_FATNESS) < Player.EPS) {
  			backButton.transform.position = player.transform.position + new Vector3(1 , 0, 0) * Player.MENU_DIST;
  		} else if ((room.transform.localScale.x / 2 - Player.PLAYER_FATNESS - player.transform.position.x) < Player.EPS) {
  			backButton.transform.position = player.transform.position - new Vector3(1, 0, 0) * Player.MENU_DIST;
  		} else if ((player.transform.position.z - Player.PLAYER_FATNESS) < Player.EPS) {
  			backButton.transform.position = player.transform.position + new Vector3(0, 0, 1) * Player.MENU_DIST;
  		} else if ((room.transform.localScale.z / 2 - Player.PLAYER_FATNESS - player.transform.position.z) < Player.EPS) {
  			backButton.transform.position = player.transform.position - new Vector3(0, 0, 1) * Player.MENU_DIST;
  		}

<<<<<<< HEAD
  		Debug.Log(leaveMenu.transform.position.x);
=======
  		Debug.Log(backButton.transform.position.x);
>>>>>>> 98ab8a4cc4886e486e1953790b680f2eba19c172
	}

	public void onBack() {
		if (Player.zone == Player.PlayerZone.SELECTION) {
			Player.zone = Player.PlayerZone.WALKING;
			GameObject player = GameObject.Find("Player");
			player.transform.position = Player.PLAYER_DEFAULT_POSITION;
<<<<<<< HEAD
			GameObject leaveMenu = GameObject.Find("LeaveMenu");
			leaveMenu.transform.position = HIDDEN_DEFAULT_POSITION;
			GameObject pens = GameObject.Find("Pens");
			pens.transform.position = HIDDEN_DEFAULT_POSITION;
=======
			GameObject backButton = GameObject.Find("BackButton");
			backButton.transform.position = HIDDEN_DEFAULT_POSITION;
>>>>>>> 98ab8a4cc4886e486e1953790b680f2eba19c172
		}
	}

}
