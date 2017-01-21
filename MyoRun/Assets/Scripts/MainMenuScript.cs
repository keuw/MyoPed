﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
	public void NewGame(string newGameLevel){	
		SceneManager.LoadScene (newGameLevel);
	}
	public void ExitGame() {
		Application.Quit ();
	}
}