using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	float x;
	void Update () {
		
		x += Time.deltaTime * 50;
		transform.rotation = Quaternion.Euler(0,0,x);
		
	}
}
