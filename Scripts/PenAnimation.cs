using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PenAnimation : MonoBehaviour {
	private int raise = 1; 
	private GameObject pen;
	private Vector3 InitialPosition;
	public bool selected = false;
	private Vector3 initPos;
	void Start () {
		initPos = transform.position;
	}
	
	// Update is called once per frame
	public void Update () {
	}

	public void toggleSelect(){
		selected = selected ? false : true;
		if(selected){
			transform.position = new Vector3(transform.position.x, transform.position.y+raise, transform.position.z);
		}
		else{
			transform.position = initPos;
		}
		
	}
}
