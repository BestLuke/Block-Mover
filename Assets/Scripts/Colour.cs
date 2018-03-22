using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//gameObject.GetComponent<Renderer> ().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Pusher.trapped == false)
		{
			gameObject.GetComponent<Renderer> ().material.color = Color.green;
			//gameObject.GetComponent<Renderer> ().material.color = Color.green;
		}
		if (Pusher.trapped == true) 
		{
			//gameObject.GetComponent<Renderer> ().material.color = Color.red;
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}

	}
}
