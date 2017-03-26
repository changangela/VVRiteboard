using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Pens : MonoBehaviour {
	public void Awake() {

	}

	public void onGreen() {
		Debug.Log("Green pen tool selected...");
		Player.zone = Player.PlayerZone.DRAWING;
		Material pointerMaterial = Resources.Load("pointer-material") as Material;
		pointerMaterial.color = new Color(0, 255, 0);

		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;

		GameObject spot = GameObject.Find("Spot");
		spot.GetComponent<Renderer>().material = Resources.Load("green-material") as Material;
	}

	public void onBlue() {
		Debug.Log("Blue pen tool selected...");
		Player.zone = Player.PlayerZone.DRAWING;
		Material pointerMaterial = Resources.Load("pointer-material") as Material;
		pointerMaterial.color = new Color(0, 0, 255);
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;

		GameObject spot = GameObject.Find("Spot");
		spot.GetComponent<Renderer>().material = Resources.Load("blue-material") as Material;
	}

	public void onRed() {
		Debug.Log("Red pen tool selected...");
		Player.zone = Player.PlayerZone.DRAWING;
		Material pointerMaterial = Resources.Load("pointer-material") as Material;
		pointerMaterial.color = new Color(255, 0, 0);
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;

		GameObject spot = GameObject.Find("Spot");
		spot.GetComponent<Renderer>().material = Resources.Load("red-material") as Material;
	}

	public void onBlack() {
		Debug.Log("Black pen tool selected...");
		Player.zone = Player.PlayerZone.DRAWING;
		Material pointerMaterial = Resources.Load("pointer-material") as Material;
		pointerMaterial.color = new Color(0, 0, 0);
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;
		GameObject spot = GameObject.Find("Spot");
		spot.GetComponent<Renderer>().material = Resources.Load("black-material") as Material;
	}

	public void onEraser() {
		Debug.Log("Eraser tool selected...");

		Player.zone = Player.PlayerZone.ERASING;
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;	
	}
	public void onUndo() {
		Debug.Log("Undo tool selected...");

		Player.zone = Player.PlayerZone.UNDOING;
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;
	}

	public void onClear() {
		for (int i = 0; i < Player.spots.Count; ++i) {
			Destroy(Player.spots[i]);
		}
		Player.spots.Clear();


	}

	public void onSpot(GameObject spot) {
		if (Player.zone == Player.PlayerZone.ERASING && Input.GetMouseButton(0)) {
			Player.spots.Remove(spot); 
			Destroy(spot);
		}
	}
}
