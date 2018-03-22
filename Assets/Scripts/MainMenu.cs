using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {


	public void StartGame()
	{
		Application.LoadLevel ("Level Select");
	}

	public void Instructions()
	{
		//	Application.LoadLevel ();
	}

	public void EndGame()
	{
		Application.Quit ();
	}
}
