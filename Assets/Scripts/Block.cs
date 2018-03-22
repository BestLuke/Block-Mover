using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	public RigidbodyConstraints constraints;
	public Rigidbody rigidbody;
	//public AudioClip scrape;
	public GameObject arms;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col)
	{
		float force = 0.5f;

		if(col.gameObject.tag == "Player")
		{
			GetComponent<Rigidbody> ().isKinematic = false;
			Vector3 dir = col.contacts [0].point - transform.position;
			dir = -dir.normalized;
			GetComponent<Rigidbody> ().AddForce (dir * force);
			arms.SetActive (true);
			//AudioSource audio = gameObject.AddComponent<AudioSource> ();
			//audio.PlayOneShot (scrape);
		}





	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "Player" && Faller.inAir == false) 
		{
			GetComponent<Rigidbody> ().isKinematic = true;
			arms.SetActive (false);
		}
	}

//	void OnTriggerExit(Collider col)
//	{
	//	if(col.gameObject.tag == "Block")
	//		{
	//		col.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
	//		}
	//}

	IEnumerator UnFreeze()
	{
		yield return new WaitForSeconds (2f);
		gameObject.GetComponent<Rigidbody> ().isKinematic = false;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Block")
		{
			col.gameObject.GetComponent<Rigidbody> ().isKinematic = true;
			StartCoroutine (UnFreeze());
		}

	}

	void LateUpdate()
	{
		StopCoroutine (UnFreeze ());
	}
}
