using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryMode : Mode {

	int num = 0;


	public override string getEvent(){
		return events[num++];
	}


	public override bool isFinished(){
		return num == events.Length;
	}
}
