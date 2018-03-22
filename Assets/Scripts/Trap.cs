using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {
	 
	public Rigidbody rigidbody;
	public GameObject block;
	public static bool onTrap = false;
	// Use this for initialization
	void Awake () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Pusher.trapped == false)
		{

			//RigidbodyConstraints.FreezePosition;
			gameObject.GetComponent<Rigidbody>();
			rigidbody.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotation;
		}
		if(Pusher.trapped == true)
		{
			//RigidbodyConstraints.None;
			gameObject.GetComponent<Rigidbody>();
			rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
		}
	//	if(Pusher.trapped == false)
		//{
			//RigidbodyConstraints.FreezePosition;
		//	RigidbodyConstraints.None;
	//	}
	//	if(Pusher.trapped == true)
	//	{
			//RigidbodyConstraints.None;
	//		RigidbodyConstraints.FreezePosition;
	//	}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "BBlock") 
		{
			onTrap = true;
		}
		/*if(Pusher.trapped == false)
		{
			
			//RigidbodyConstraints.FreezePosition;
			col.GetComponent<Rigidbody>();
			rigidbody.constraints = RigidbodyConstraints.None | RigidbodyConstraints.FreezeRotation;
		}
		if(Pusher.trapped == true)
		{
			//RigidbodyConstraints.None;
			col.GetComponent<Rigidbody>();
			rigidbody.constraints = RigidbodyConstraints.FreezePosition;
		}
	}*/
}

	//void OnTriggerExit(Collider col)
	//{
	//	if (col.gameObject.tag == "BBlock") {
	//		onTrap = false;
	//	}
	//}

	//void OnTriggerExit(Collider col)
	//{
		//if (col.gameObject.tag == "BBlock")
		//{
		//	onTrap = false;
	//	//}
	//}
}
