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
		menu.SetActive(false);
	}

}
