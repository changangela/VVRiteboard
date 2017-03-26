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
	}

	public void onBlue() {
		Debug.Log("Blue pen tool selected...");
		Player.zone = Player.PlayerZone.DRAWING;
		Material pointerMaterial = Resources.Load("pointer-material") as Material;
		pointerMaterial.color = new Color(0, 0, 255);
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;
	}

	public void onRed() {
		Debug.Log("Red pen tool selected...");
		Player.zone = Player.PlayerZone.DRAWING;
		Material pointerMaterial = Resources.Load("pointer-material") as Material;
		pointerMaterial.color = new Color(255, 0, 0);
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;
	}

	public void onBlack() {
		Debug.Log("Black pen tool selected...");
		Player.zone = Player.PlayerZone.DRAWING;
		Material pointerMaterial = Resources.Load("pointer-material") as Material;
		pointerMaterial.color = new Color(0, 0, 0);
		GameObject pens = GameObject.Find("Pens");
		pens.transform.position = ConfirmMenu.HIDDEN_DEFAULT_POSITION;
	}

	public void onEraser() {
		Debug.Log("Eraser tool selected...");
	}
}
