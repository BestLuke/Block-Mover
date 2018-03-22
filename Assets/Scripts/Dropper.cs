using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour {

	public GameObject player;
	public bool playerChange = false;
	static public bool levelOne = false;
	static public bool levelTwo = false;
	static public bool levelThree = false;
	static public bool levelFour = false;
	static public bool levelFive = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (playerChange == true && levelOne == true) {
			player.gameObject.transform.position = new Vector3 (0,0,4.931f);
			playerChange = false;
		}
		if (playerChange == true && levelTwo == true) {
			player.gameObject.transform.position = new Vector3 (4.214f,-12.175f,3.374f);
			player.gameObject.transform.rotation = new Quaternion (0,180,0,0);
			playerChange = false;
		}
		
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "BBlock" && levelOne == true) {

			col.gameObject.transform.position = new Vector3 (0, -1.989f, 6.521f);
			playerChange = true;
		}
		if (col.gameObject.tag == "BBlock" && levelTwo == true) {

			col.gameObject.transform.position = new Vector3 (4.146f,-14.052f,2.191f);
			playerChange = true;
		}
	}
}
