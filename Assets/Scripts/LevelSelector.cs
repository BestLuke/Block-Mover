using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Level1()
	{
		Application.LoadLevel ("Start");
		Dropper.levelOne = true;
		Dropper.levelTwo = false;
		Dropper.levelThree = false;
		Dropper.levelFive = false;
		Dropper.levelFour = false;
	}
	public void Level2()
	{
		Application.LoadLevel ("Level2");
		Dropper.levelOne = false;
		Dropper.levelTwo = true;
		Dropper.levelThree = false;
		Dropper.levelFive = false;
		Dropper.levelFour = false;
	}
	public void Level3()
	{
		//Application.LoadLevel ("");
	}
	public void Level4()
	{
		//Application.LoadLevel ("");
	}
	public void Level5()
	{
		//Application.LoadLevel ("");
	}
	public void Level6()
	{
		//Application.LoadLevel ("");
	}
	public void Level7()
	{
		//Application.LoadLevel ("");
	}
	public void Level8()
	{
		//Application.LoadLevel ("");
	}
}
