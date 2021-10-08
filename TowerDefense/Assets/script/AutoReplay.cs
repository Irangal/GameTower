﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine .SceneManagement ;

public class AutoReplay : MonoBehaviour {
	float timer = 0;
	public Text info;

	// Use this for initialization
	void Start () {
		if (Data.isComplate) {
			info.text = (" Congratulation \n You Win");
		}
		else {
			info .text = ("Game Over \n You Lose");
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		timer += Time.deltaTime;
		if (timer > 3) {
			Data.isComplate = false;
			Data.isGameOver = false;
			Data.coin = 0;
			SceneManager.LoadScene ("GamePlay");
		}
	}
}
		

