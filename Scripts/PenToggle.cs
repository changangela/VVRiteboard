using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PenToggle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void toggleDown() {
		transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);

	}

	public void toggleUp() {
		transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
	}
}
