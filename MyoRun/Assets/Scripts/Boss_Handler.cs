using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Handler : MonoBehaviour
{
    private float verticalSize;
    private float horizontalSize;


    public Knight_Boss knight;
    public Sword sword;
    public Spider spider;
    private Animator spiderAnim;
    private Animator knightAnim;
    private Animator swordAnim;


    public bool win;
    
    // Use this for initialization
    void Start()
    {
        win = false;

        spiderAnim = spider.GetComponent<Animator>();
        knightAnim = knight.GetComponent<Animator>();
        swordAnim = sword.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            knightAnim.Play("Knight_Boss_Jump");
            swordAnim.Play("Sword_Grab");

        }
    }

}