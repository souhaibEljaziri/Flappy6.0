using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

	public AudioClip[] tracks;
	AudioSource audioComponent;

	public static bool instance;

	void Awake ()
	{
		if (!instance)
			instance = this;
		else
			Destroy (gameObject);

		DontDestroyOnLoad (this.gameObject);
	}

	void Start ()
	{
		audioComponent = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (!audioComponent.isPlaying) {
			audioComponent.clip = tracks [Random.Range (0, 1)];
			audioComponent.Play ();
		}
	}

	public void mute ()
	{
		audioComponent.enabled = !audioComponent.enabled;
	}
} 