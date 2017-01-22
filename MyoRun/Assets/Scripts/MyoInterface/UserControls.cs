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

	void Start(){
		DontDestroyOnLoad(transform.gameObject);
	}

	void Update(){
		thMyo = myo.GetComponent<ThalmicMyo> ();
	}

	public static bool samePose(Pose pose){
		return pose == thMyo.pose;
	}
}
