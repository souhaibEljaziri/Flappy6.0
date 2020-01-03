﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class BirdMovement : MonoBehaviour {

	Vector3 velocity = Vector3.zero;
	public float flapSpeed    = 100f;
	public float forwardSpeed = 1f;
	public GameObject loseScreen; 
	bool didFlap = false;
	public AudioSource JumpAudio; 

	public static int levl ; 

	Animator animator;

	public bool dead = false;
	float deathCooldown;

	public bool godMode = false;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
		//flap th first time 
		GetComponent<Rigidbody2D>().AddForce( Vector2.up * flapSpeed );
		animator.SetTrigger("DoFlap");
		//end flap script
		if(animator == null) {
			Debug.LogError("Didn't find animator!");
		}
	}

	// Do Graphic & Input updates here
	void Update() {
		if(dead) {
			deathCooldown -= Time.deltaTime;

			/*if(deathCooldown <= 0) {
				if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) ) {
					Application.LoadLevel( Application.loadedLevel );

				}
			}*/
		}
		else {
			if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) ) {
				didFlap = true;
			}
		}
	}

	
	// Do physics engine updates here
	void FixedUpdate () {

		if (dead) {
			loseScreen.SetActive(true);  
			return;
		}

		GetComponent<Rigidbody2D>().AddForce( Vector2.right * forwardSpeed );

		if(didFlap) {
			//sound !! 
			if(GetComponent<Collider2D>().enabled == true )
			JumpAudio.Play() ; 
			GetComponent<Rigidbody2D>().AddForce( Vector2.up * flapSpeed );
			animator.SetTrigger("DoFlap");


			didFlap = false;
		}

		if(GetComponent<Rigidbody2D>().velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {
			float angle = Mathf.Lerp (0, -90, (-GetComponent<Rigidbody2D>().velocity.y / 3f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if(godMode)
			return;

		animator.SetTrigger("Death");
		dead = true;
		deathCooldown = 0.5f;
		if (UnityEngine.Random.Range (1f, 10.0f) > 8f) {
			AdMobManager adManager = (AdMobManager)FindObjectOfType (typeof(AdMobManager));
			adManager.ShowInterstitial ();
		}
	}

	public void restart()
	{	
		Application.LoadLevel( Application.loadedLevel );
	}
	public void menu()
	{	
		Application.LoadLevel("Main");
	}
	public void nextLevel()
	{	
		Scene scene = SceneManager.GetActiveScene();
		int levelToLoad = Int32.Parse (scene.name) + 1;
		Application.LoadLevel(levelToLoad.ToString());
	}




}
