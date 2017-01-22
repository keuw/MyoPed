using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour {
    private Animator playerAnimator;
    public Transform playerTrans;
    public bool atGoal;
    public bool winMove;

    public float enterWait = 3;

    // Use this for initialization
    void Start () {
        playerAnimator = GetComponent<Animator>();
        playerTrans = GetComponent<Transform>();

        atGoal = false;
        winMove = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (playerTrans.position.x <= -1) {
            playerAnimator.SetInteger("AnimationState", 1);
            playerTrans.Translate(-Time.deltaTime*3, 0, 0);
        }
        else
        {
            
            if (winMove == false)
            {
                atGoal = true;
                playerAnimator.SetInteger("AnimationState", 2);
                
            }
        }
        
        if (winMove == true)
        {
            if (enterWait > 0)
            {
                enterWait -= Time.deltaTime;
                playerAnimator.SetInteger("AnimationState", 0);
            }
            else
            {
                playerTrans.Translate(-Time.deltaTime * 3, 0, 0);
                playerAnimator.SetInteger("AnimationState", 1);
            }
        }

    }
}
