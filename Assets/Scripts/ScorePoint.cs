using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {
	

	 


	void OnTriggerEnter2D(Collider2D collider) {
		
		if(collider.tag == "Player") {
			
			GameObject.Find("guiScore").GetComponent<Score>().AddPoint();


		}


	}
}
