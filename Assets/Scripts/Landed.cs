using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landed : MonoBehaviour {

	public Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "BBlock") {
			Faller.inAir = false;
			rigidbody.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotation;
		}
	}
}
