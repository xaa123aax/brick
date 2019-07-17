using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossScript : MonoBehaviour
{

    public float speed;
    private float bosstimer;
    private float waitTime = 1;
    private Vector3 bossPosition;
    private Vector2 bossInitialForce;
    int bosschange;
    private float speeda;
    


    void Start()
    {






            speeda = speed * Mathf.Sqrt(2);
            bossPosition = transform.position;

            bosschange = UnityEngine.Random.Range(1, 9);
            switch (bosschange)
            {
                //左上
                case 1:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, speed);
                    break;
                //上
                case 2:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, speeda);
                    break;
                //右上
                case 3:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(speed, speed);
                    break;
                //左
                case 4:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-speeda, 0);
                    break;
                //右
                case 5:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(speeda, 0);
                    break;
                //左下
                case 6:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, -speed);
                    break;
                //下
                case 7:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speeda);
                    break;
                //右下
                case 8:
                    GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -speed);
                    break;

            }
        }




        void Update()
        {








        bosstimer += Time.deltaTime;
               
        //如果時間大於等待時間

        if (bosstimer > waitTime)
        {

            GameObject newStar5 = Instantiate(Resources.Load<GameObject>("bonus5"));
            newStar5.transform.position = gameObject.transform.position;
            //把時間歸0
            bosstimer = bosstimer - waitTime;

        }

        if (transform.position.y < 0)
            {
                transform.position = new Vector2(transform.position.x, 0);
                bosschange = UnityEngine.Random.Range(1, 8);
                switch (bosschange)
                {
                    //左上
                    case 1:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, speed);
                        break;
                    //上
                    case 2:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speeda);
                        break;
                    //右上
                    case 3:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, speed);
                        break;
                    //左
                    case 4:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speeda, 0);
                        break;
                    //右
                    case 5:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speeda, 0);
                        break;
                    //左上
                    case 6:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, speed);
                        break;
                    case 7:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, speed);
                        break;

                }



            }
            if (transform.position.y > 4)
            {
                transform.position = new Vector2(transform.position.x, 4);
                bosschange = UnityEngine.Random.Range(2, 9);

                switch (bosschange)
                {
                    //左
                    case 4:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speeda, 0);
                        break;
                    //右
                    case 5:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speeda, 0);
                        break;
                    //左下
                    case 6:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, -speed);
                        break;
                    //下
                    case 7:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speeda);
                        break;
                    //右下
                    case 8:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -speed);
                        break;
                    //左下
                    case 3:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, -speed);
                        break;
                    //右下
                    case 2:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -speed);
                        break;

                }

            }
            if (transform.position.x < -2.1f)
            {
                transform.position = new Vector2(-2.1f, transform.position.y);
                bosschange = UnityEngine.Random.Range(1, 8);
                switch (bosschange)
                {

                    //上
                    case 2:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speeda);
                        break;
                    //右上
                    case 3:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, speed);
                        break;
                    //右
                    case 4:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speeda, 0);
                        break;
                    //下
                    case 5:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speeda);
                        break;
                    //右下
                    case 1:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -speed);
                        break;
                    //右上
                    case 6:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, speed);
                        break;
                    //右下
                    case 7:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, -speed);
                        break;

                }


            }
            if (transform.position.x > 8.5f)
            {
                transform.position = new Vector2(8.5f, transform.position.y);
                bosschange = UnityEngine.Random.Range(1, 8);
                switch (bosschange)
                {
                    //左上
                    case 1:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, speed);
                        break;
                    //上
                    case 2:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, speeda);
                        break;

                    //左
                    case 3:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speeda, 0);
                        break;

                    //左下
                    case 4:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, -speed);
                        break;
                    //下
                    case 5:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speeda);
                        break;
                    //左上
                    case 6:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, speed);
                        break;
                    //左下
                    case 7:
                        GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, -speed);
                        break;


                }



            }
            Debug.Log(GetComponent<Rigidbody2D>().velocity);
        }
    }



