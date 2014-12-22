﻿using UnityEngine;
using System.Collections;

public class PlayerTracksCamera : MonoBehaviour {

	Transform player;

	float offsetX;

	// Use this for initialization
	void Start () {
		GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
		if(playerGO == null){
			Debug.LogError("cant find player");
			return;
		}
		player = playerGO.transform;

		offsetX = transform.position.x - player.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null){
			Vector3 pos = transform.position;
			pos.x =player.position.x + offsetX;
			transform.position = pos;
		}	
	}
}
