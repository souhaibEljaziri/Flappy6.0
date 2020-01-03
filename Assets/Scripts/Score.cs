using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Score : MonoBehaviour {

	static int score = 1;
	public int MaxScore;
	static int level= 1;
	public GameObject WinDialog;
	static Score instance;
	public AudioSource audio; 
	public GameObject winParty; 
	GameObject player_go ; 

	public void AddPoint() {
		
		if(instance.bird.dead)
			return;

		 Rigidbody2D rb =	player_go.GetComponent<Rigidbody2D>();
		Collider2D cd=  player_go.GetComponent<Collider2D> ();

		score++;

		audio.Play (); 

		if ((score >= MaxScore) && (level <= 50)) {
			
			winParty.active = true; 
			//rb.bodyType = RigidbodyType2D.Static;
			rb.constraints = RigidbodyConstraints2D.FreezePositionY;
			cd.enabled = false; 
			WinDialog.SetActive(true);


			Scene scene = SceneManager.GetActiveScene();
			if(level >= Int32.Parse(scene.name)){
				PlayerPrefs.SetInt("level",level=Int32.Parse(scene.name)+1);
			}
		}
	}

	BirdMovement bird;

	void Start() {
		instance = this;
		 player_go = GameObject.FindGameObjectWithTag("Player");
		if(player_go == null)
		{
			Debug.LogError("Could not find an object with tag 'Player'.");
		}

		bird = player_go.GetComponent<BirdMovement>();
		score = 0;
		level = PlayerPrefs.GetInt("level", 1);

	
	}

	void OnDestroy() {
		instance = null;
		PlayerPrefs.SetInt("level", level);
	}
	int a;
	void Update () {

		Scene scene = SceneManager.GetActiveScene();
		a= System.Convert.ToInt32(scene.name);
		MaxScore=(5+((a-1)%10)+((a-1)/10));
		GetComponent<GUIText>().text = "Score: " + score+"/"+MaxScore+ "\nLevel: " + scene.name;


	}
}
