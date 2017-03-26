using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmMenu : MonoBehaviour {
	public static Vector3 HIDDEN_DEFAULT_POSITION = new Vector3(10000, 0, 10000);

	public void Awake() {

	}

	public void onNo() {
		// Debug.Log("Selection: no");
		// GameObject player = GameObject.Find("Player");
		// player.transform.position = Player.PLAYER_DEFAULT_POSITION;
		// GameObject menu = GameObject.Find("ConfirmMenu");

		// menu.transform.position = HIDDEN_DEFAULT_POSITION;
		// Player.zone = Player.PlayerZone.WALKING;
	}

	public void onYes() {
		// Debug.Log("Selection: yes");
		// Player.zone = Player.PlayerZone.SELECTION;
		
		// GameObject menu = GameObject.Find("ConfirmMenu");
		// menu.transform.position = HIDDEN_DEFAULT_POSITION;

		// GameObject player = GameObject.Find("Player");

		// GameObject leaveMenu = GameObject.Find("LeaveMenu");
		// leaveMenu.transform.position = HIDDEN_DEFAULT_POSITION;

		// GameObject room = GameObject.Find("Room");
		
		// GameObject pens = GameObject.Find("Pens");

		// if ((player.transform.position.x - Player.PLAYER_FATNESS) < Player.EPS) {
  // 			leaveMenu.transform.position = player.transform.position + new Vector3(1 , 0, 0) * Player.MENU_DIST;
  // 			pens.transform.position = new Vector3(player.transform.position.x, 20, player.transform	.position.z) - new Vector3(1, 0, 0) * Player.PEN_DIST;
  // 			pens.transform.forward = new Vector3(1, 0, 0);
  // 			leaveMenu.transform.forward = new Vector3(1, 0, 0);
  // 		} else if ((room.transform.localScale.x / 2 - Player.PLAYER_FATNESS - player.transform.position.x) < Player.EPS) {
  // 			leaveMenu.transform.position = player.transform.position - new Vector3(1, 0, 0) * Player.MENU_DIST;
  // 			pens.transform.position = new Vector3(player.transform.position.x, 20, player.transform	.position.z) + new Vector3(1, 0, 0) * Player.PEN_DIST;
  // 			pens.transform.forward = new Vector3(1, 0, 0);
  // 			leaveMenu.transform.forward = new Vector3(-1, 0, 0);
  // 		} else if ((player.transform.position.z - Player.PLAYER_FATNESS) < Player.EPS) {
  // 			leaveMenu.transform.position = player.transform.position + new Vector3(0, 0, 1) * Player.MENU_DIST;
		// 	pens.transform.position = new Vector3(player.transform.position.x, 20, player.transform	.position.z) - new Vector3(0, 0, 1) * Player.PEN_DIST;
		// 	pens.transform.forward = new Vector3(0, 0, 1);
		// 	leaveMenu.transform.forward = new Vector3(0, 0, 1);
  // 		} else if ((room.transform.localScale.z / 2 - Player.PLAYER_FATNESS - player.transform.position.z) < Player.EPS) {
  // 			leaveMenu.transform.position = player.transform.position - new Vector3(0, 0, 1) * Player.MENU_DIST;
  // 			pens.transform.position = new Vector3(player.transform.position.x, 20, player.transform	.position.z) + new Vector3(0, 0, 1) * Player.PEN_DIST;
  // 			pens.transform.forward = new Vector3(0, 0, 1);
  // 			leaveMenu.transform.forward = new Vector3(0, 0, -1);
  // 		}

  // 		Debug.Log(leaveMenu.transform.position.x);
	}

	public void onExplore() {
		if (Player.zone == Player.PlayerZone.SELECTION) {
			Player.zone = Player.PlayerZone.WALKING;
			GameObject pens = GameObject.Find("Pens");
			pens.transform.position = HIDDEN_DEFAULT_POSITION;
		}
	}

}
