﻿using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int numBGPanels = 6;

	float pipeMAx = 1.12f;
	float pipeMin = 0.65f;

	void Start(){
		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("Pipe");

		foreach(GameObject pipe in pipes){
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range (pipeMin, pipeMAx);
			pipe.transform.position = pos;
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Triggered:" + collider.name);

		float widthOfBGObject = ((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;

		pos.x += widthOfBGObject * numBGPanels;


		if (collider.tag == "Pipe") {
			pos.y = Random.Range (pipeMin, pipeMAx);
		}
		collider.transform.position = pos;
	}
}