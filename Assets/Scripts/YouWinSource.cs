using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinSource : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find("Canwin").SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
