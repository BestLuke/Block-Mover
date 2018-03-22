using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	void Awake()
	{
		Pusher.trapped = true;
	}
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (Trap.onTrap == true) 
		{
			Pusher.trapped = false;
		}
		
	}

	void OnTriggerExit(Collider col)
	{
		if (Trap.onTrap == true)
		{
			Pusher.trapped = true;
		}
	}
}
