using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose_screen : MonoBehaviour {
	
	Transform player;
	// Use this for initialization
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		player = player_go.transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(player != null) {
			Vector3 pos = transform.position;
			pos.x = player.position.x ;
			transform.position = pos;
		}
		//transform.position = p.transform.position; 
	}
}
