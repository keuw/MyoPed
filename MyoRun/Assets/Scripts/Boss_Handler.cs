using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Handler : MonoBehaviour
{
    private float verticalSize;
    private float horizontalSize;


    public Knight knight;
    public Sword sword;
    public Spider spider;
    public Circle circle;
    private Animator spiderAnim;
    private Animator knightAnim;
    private Animator swordAnim;
    private Animator circleAnim;

    private bool startEnding = false;
    private float endWait = 5;

    public bool win;
    

    // Use this for initialization
    void Start()
    {
        win = false;

        spiderAnim = spider.GetComponent<Animator>();
        knightAnim = knight.GetComponent<Animator>();
        swordAnim = sword.GetComponent<Animator>();
        circleAnim = circle.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            knightAnim.SetInteger("AnimationState", 2);
            swordAnim.SetInteger("DropState", 1);
            circleAnim.SetInteger("ExpandCircle", 1);
            startEnding = true;
            

        }
        if (startEnding)
        {
            endWait -= Time.deltaTime;

        }
        if(endWait < 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
        }
    }

}