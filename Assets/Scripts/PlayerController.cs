using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;
    private bool isGrounded;
    public Transform groundCheckPiont;
    public LayerMask WhatIsGround;
    private bool canDoubleJump;
    private Animator anim;
    private SpriteRenderer theSR;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        theSR=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //控制水平速度
        theRB.velocity=new Vector2(moveSpeed*Input.GetAxis("Horizontal"),theRB.velocity.y);
        //判断是否在地面上
        isGrounded=Physics2D.OverlapCircle(groundCheckPiont.position,.2f,WhatIsGround);
        //如果玩家在地面上，则可以使用double jump
        if(isGrounded)canDoubleJump=true;

        //控制垂直速度
        if(Input.GetButtonDown("Jump")){
            if(isGrounded){//如果在地面上
                theRB.velocity=new Vector2(theRB.velocity.x,jumpForce);
            }
            else{//如果不在地面上
                if(canDoubleJump){//如果二段跳为true
                    theRB.velocity=new Vector2(theRB.velocity.x,jumpForce);
                    canDoubleJump=false;//跳完两段跳之后，把二段跳开关重置为false
                }
            }
        }

        //设置动画条件变量
        anim.SetFloat("moveSpeed",Mathf.Abs(theRB.velocity.x));
        anim.SetBool("isGrounded",isGrounded);

        //玩家面向不同地方时的动画反向
        if(theRB.velocity.x<0)theSR.flipX=true;
        else if(theRB.velocity.x>0) theSR.flipX=false;
        //没有处理等于0的情况是因为0会有-0和+0两种，由上一个状态决定

        
    }
}
