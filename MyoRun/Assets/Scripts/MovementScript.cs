using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
	public float speed ;
	public float jumpPower;

	public bool grounded;

    private Rigidbody2D rig;
    private Collider2D playerCollider;
    // Use this for initialization
    void Start () {
		rig = GetComponent<Rigidbody2D> ();
        playerCollider = GetComponent<Collider2D>();
    }
	
	// Update is called once per frame
	void Update () {

        rig.velocity = new Vector2(speed, rig.velocity.y);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (grounded)
            {
                rig.velocity = new Vector2(rig.velocity.x, jumpPower);
            }
        }
      
    }

}
