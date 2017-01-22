﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour {
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

    // Use this for initialization
    void Start () {
        win = false;

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
        
        if (Input.GetKeyDown(KeyCode.Space) && knight.atGoal == true)
        {
            lever.GetComponent<SpriteRenderer>().color = new Color(0, 0, 255);
            knight.winMove = true;
            
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
            win = true;
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
