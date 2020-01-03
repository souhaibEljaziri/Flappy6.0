using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : MonoBehaviour {

	public GameObject level;
	public GameObject lockIcon;
	private int currentLevel;

	// Use this for initialization
	void Start () {
		currentLevel = PlayerPrefs.GetInt("level",1);
		level.GetComponent<Text>().text = currentLevel.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void nextLevel(){
		if (level.GetComponent<Text> ().text != "200") {
			level.GetComponent<Text>().text = (Int32.Parse(level.GetComponent<Text>().text) + 1).ToString();
		}
		if(currentLevel < Int32.Parse(level.GetComponent<Text> ().text)){
			lockIcon.SetActive (true);
		}
	}

	public void previousLevel(){
		if (level.GetComponent<Text> ().text != "1") {
			level.GetComponent<Text>().text = (Int32.Parse(level.GetComponent<Text>().text) - 1).ToString();
		}
		if(currentLevel >= Int32.Parse(level.GetComponent<Text> ().text)){
			lockIcon.SetActive (false);
		}
	}
	public void play(){
		if (currentLevel >= Int32.Parse (level.GetComponent<Text> ().text)) {
			Application.LoadLevel (level.GetComponent<Text> ().text);
		} 
	}

	public void mute(){
		SoundManager soundManager = (SoundManager)FindObjectOfType (typeof(SoundManager));
		soundManager.mute ();
	}
}
