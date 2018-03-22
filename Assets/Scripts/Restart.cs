using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		
		if (col.gameObject.tag == "Player")
		{
			print ("Touch");
			//Application.LoadLevel("Start");
			StartCoroutine (Replay());
		}
	}
	IEnumerator Replay()
	{
		yield return new WaitForSeconds (2F);
		Pusher.trapped = true;
		if (Dropper.levelOne = true) {
			Application.LoadLevel ("Start");
		}
		if (Dropper.levelTwo = true) {
			Application.LoadLevel ("Level2");
		}
	}
}
