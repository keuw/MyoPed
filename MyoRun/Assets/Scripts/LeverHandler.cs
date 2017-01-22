using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pose = Thalmic.Myo.Pose;

public class LeverHandler : MonoBehaviour {
    private float verticalSize;
    private float horizontalSize;

    public GroundBlock block;
    public Knight knight;
    public Lever lever;
    public Bridge bridge;
    public Fist fist;
    public Arrow arrow;
    
    private Animator bridgeAnim;
    private Animator fistAnim;
    private Animator arrowAnim;

    public bool win;
    
	public double pastVal = -1.0;
    
    // Use this for initialization
    void Start () {

        verticalSize = Camera.main.orthographicSize;
        horizontalSize = verticalSize * Screen.width / Screen.height;

        bridgeAnim = bridge.GetComponent<Animator>();
        fistAnim = fist.GetComponent<Animator>();
        arrowAnim = arrow.GetComponent<Animator>();

        for (int i = 0; i < 20; i++)
        {
            Instantiate(block, new Vector3((i * 0.5f)-horizontalSize, 0- verticalSize+0.48f, 0),Quaternion.identity);
        }

    
    }

    // Update is called once per frame
    void Update()
    {
        
		if (Input.GetKeyDown(KeyCode.UpArrow) && knight.atGoal == true) {
			if (pastVal == -1.0) {
				pastVal = UserControls.getHeight ();
			} else if (pastVal - UserControls.getHeight () > 0.4) {
				lever.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 255);
				knight.winMove = true;
			}
            
		} else {
			pastVal = -1.0;
		}

        if (knight.winMove == true)
        {
            if (knight.enterWait > 0)
            {
                bridgeAnim.Play("Bridge_drop");

            }
        }
        if (knight.playerTrans.position.x >= 10)
        {
			GameScript.won = true;
        }
        if (knight.atGoal == true && knight.winMove == false)
        {
            fistAnim.Play("Fist");
            arrowAnim.Play("Arrow");
        }
        if(knight.winMove == true)
        {
            fistAnim.Play("Fist_Idle");
            arrowAnim.Play("Arrow_Idle");
        }
    }

}
