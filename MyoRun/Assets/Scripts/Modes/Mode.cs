using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Mode{

	//List of Possible Events
	protected string[] events = new string[1] {"LeverScene"};

	protected string bossFight = "BossScene";

	//Generates the next event for the game.
	public abstract string getEvent();

	//Returns whether or not the current mode is finished.
	public abstract bool isFinished();

	public string getBoss(){
		return bossFight;
	}
}
