using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndlessMode : Mode {

	public override string getEvent(){
		int n = UnityEngine.Random.Range(0, events.Length);
		return events[n];
	}


	public override bool isFinished(){
		return false;
	}
}
