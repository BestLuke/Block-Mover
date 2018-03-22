using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faller : MonoBehaviour {

	static public bool inAir = false;
	public Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "BBlock") {
			gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			inAir = true;

			rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
		}
	}
}
