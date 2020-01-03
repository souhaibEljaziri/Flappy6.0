using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_selector : MonoBehaviour {
	string x ; 
	public GameObject levl_panel;
	// Use this for initialization
	void Start () {
		x= this.gameObject.name; 

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void affiche()
	{	BirdMovement.levl = int.Parse(x); 
		levl_panel.SetActive (false); 
		Time.timeScale = 1;
		Application.LoadLevel( Application.loadedLevel );
		Debug.Log (x); 
	}
}
