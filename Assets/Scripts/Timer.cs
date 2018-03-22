using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

//Timer To CountDown Script

	public float timeLeft;
	public Text timerText;



		


	void Start()
	{
		if (Dropper.levelOne == true) {
			timeLeft = 30f;
		}
		if (Dropper.levelTwo == true) {
			timeLeft = 60f;
		}
	}
	void Update()
	{
		timeLeft -= Time.deltaTime;
		if (Dropper.levelOne == true) {
			timerText.text = (timeLeft + " Seconds");


			if (timeLeft <= 0) {
				Application.LoadLevel ("Start");

			}
		}
		if (Dropper.levelTwo == true) {
			timerText.text = (timeLeft + " Seconds");


			if (timeLeft <= 0) {
				Application.LoadLevel ("Level2");
			}
		}

	}




}
