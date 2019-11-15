﻿using UnityEngine;
using System.Collections;

public class GroundMover : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D player;
	void Start () {
	GameObject player_go = GameObject.FindGameObjectWithTag ("Player");

	if(player_go == null) {
		Debug.LogError ("Couldn't find an object with tag 'Player'!");
		return;
	}
		player = player_go.GetComponent<Rigidbody2D>();

}

	// Update is called once per frame
	void FixedUpdate () {
		float vel = player.velocity.x * 0.75f;

		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
	}
}
