using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour {
	//monitors if a block is trapped
	public static bool trapped = true;

	public GameObject button;
	public GameObject trap;
	public GameObject[] Blocks;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame


	/*void OnCollisionEnter(Collision col)
	{
		float force = 3f;

		if(col.gameObject.tag == "Player")
		{
			Vector3 dir = col.contacts [0].point - transform.position;
			dir = -dir.normalized;
			GetComponent<Rigidbody> ().AddForce (dir * force);
		}
	}*/
}
