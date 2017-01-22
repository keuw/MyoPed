using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript{

	public static bool won = false;

	public static Mode mode = new StoryMode();

	public static bool boss = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (won) {
			if (boss) {
				SceneManager.LoadScene ("Win Screen");
			} else if (mode.isFinished ()) {
				SceneManager.LoadScene (mode.getBoss ());
			} else {
				SceneManager.LoadScene(mode.getEvent());
				won = false;
			}
		}
	}
}
