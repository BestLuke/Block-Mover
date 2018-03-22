using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			print ("Fin");
			StartCoroutine (Replay());
		}
	}



IEnumerator Replay()
{
	yield return new WaitForSeconds (2F);
	Pusher.trapped = true;
	Application.LoadLevel("Level Select");
}
}
