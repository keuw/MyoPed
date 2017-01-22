using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Pose = Thalmic.Myo.Pose;

public class GameScript : MonoBehaviour{

	public static bool won = false;

	public static Mode mode = new StoryMode();

	public static bool boss = false;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);
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
		if (UserControls.samePose (Pose.DoubleTap)) {
			if(!mode.isFinished()){
				SceneManager.LoadScene(mode.getEvent());
			}
			Debug.Log ("SamePose");
		}
		Debug.Log ("Update");
	}
}
