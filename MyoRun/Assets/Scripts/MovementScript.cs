using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LockingPolicy = Thalmic.Myo.LockingPolicy;
using Pose = Thalmic.Myo.Pose;
using UnlockType = Thalmic.Myo.UnlockType;
using VibrationType = Thalmic.Myo.VibrationType;

public class MovementScript : MonoBehaviour {
    public GameObject myo = null;

    public float speed ;
	public float jumpPower;

	public bool grounded;

    private Rigidbody2D rig;
    private Collider2D playerCollider;

    private Animator playerAnimator;
    // Use this for initialization

    void Start () {
		rig = GetComponent<Rigidbody2D> ();
        playerCollider = GetComponent<Collider2D>();
        playerAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

		// Access the ThalmicMyo component attached to the Myo game object.
		ThalmicMyo thalmicMyo = myo.GetComponent<ThalmicMyo> ();
		float movement = Input.GetAxis ("Horizontal");
		rig.velocity = new Vector2(speed * movement, rig.velocity.y);
		if (Input.GetKeyDown(KeyCode.UpArrow) || thalmicMyo.pose == Pose.DoubleTap)
        {
            if (grounded)
            {
                rig.velocity = new Vector2(rig.velocity.x, jumpPower);
            }
        }

        playerAnimator.SetFloat("Speed", rig.velocity.x);
        playerAnimator.SetBool("Grounded", grounded);
      
    }

}
