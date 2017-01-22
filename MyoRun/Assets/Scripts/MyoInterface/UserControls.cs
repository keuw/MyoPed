using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class UserControls : MonoBehaviour{

	public GameObject myo = null;

	public static ThalmicMyo thMyo;

	public static double y;

	public static string downfist = "0.785", upfist = "0.6512";

	void Start(){
		DontDestroyOnLoad(transform.gameObject);
	}

	void Update(){
		thMyo = myo.GetComponent<ThalmicMyo> ();
		y = myo.transform.forward.y;
	}

	public static bool samePose(Pose pose){
		return pose == thMyo.pose;
	}

	public static double getHeight(){
		return y;
	}
}
