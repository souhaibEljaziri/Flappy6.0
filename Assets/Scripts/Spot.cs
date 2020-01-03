using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spot : MonoBehaviour {

	public GameObject light;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (glimpe ());
		
	}


	IEnumerator glimpe ()
	{
		float	x = Random.Range (3,30);
			
		light.active = true; 

			yield return new WaitForSeconds (x/10);
		light.active = false; 






	}

}
