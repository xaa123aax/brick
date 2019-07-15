﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    private bool ballIsActive;
    private Vector3 ballPosition;
    private Vector2 ballInitialForce;
    public GameObject playerObject;
  

    void Start()
    {
        //給球一個初始的力量使遊戲開始
        ballInitialForce = new Vector2(100.0f, 300.0f);

        //活性一開始為 false
        ballIsActive = false;

        //球的位置
        ballPosition = transform.position;
    }

    void OnTriggerEnter2D(Collider2D other)
    {//如果碰到星星
        if (other.gameObject.CompareTag("star"))
        {
            //破壞星星
            other.gameObject.SetActive(false);
            //速度變兩倍
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity * 2;
        }
            if (other.gameObject.CompareTag("star2"))
            {
                //破壞星星
                other.gameObject.SetActive(false);
                //速度變兩倍
                  

            }
            if (other.gameObject.CompareTag("star3"))
            {
                //破壞星星
                other.gameObject.SetActive(false);
            //速度變1/2倍
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity ;

        }

        
  
    }
    void Update()
    {
        // 空白建噴射球
        if (Input.GetButtonDown("Jump") == true)
        {
            // 如果遊戲是剛開始
            if (!ballIsActive)
            {              

                // 他一個力量
                GetComponent<Rigidbody2D>().AddForce(ballInitialForce);
                // set ball active
                ballIsActive = !ballIsActive;
            }
        }
        //如果球還沒發射且玩家存在時
        if (!ballIsActive && playerObject != null)
        {
            // 設定球會在play的哪裡
            ballPosition.x = playerObject.transform.position.x;
            ballPosition.y = playerObject.transform.position.y+0.5f;

           //將球的位置傳遞過去
            transform.position = ballPosition;
        }
           //如果球還發射且位置小於-6(掉下去了)
        if (ballIsActive && transform.position.y < -6)
        {
            //求失去活性
            ballIsActive = !ballIsActive;
            //重設位置
            ballPosition.x = playerObject.transform.position.x;
            ballPosition.y = playerObject.transform.position.y + 0.5f;
            transform.position = ballPosition;

            //把速度給歸0
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;


            GameManager.playerLives--;
            //如果小於等於0 isDead為真
            if (GameManager.playerLives <= 0)
            {
                PlayerScript.isDead = true;
            }
         
        }


    }
}
