using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopper : MonoBehaviour {
	public Rigidbody rigidbody1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "BBlock") {
			gameObject.GetComponent<Rigidbody> ();
			rigidbody1.constraints = RigidbodyConstraints.FreezePositionX;
		}
	}
}
