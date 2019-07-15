using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerScript : MonoBehaviour
{
    public float playerVelocity;
    private Vector3 playerPosition;
    public float boundaryr;
    public float boundaryl;
    public static bool isDead;
    


    void Start()
    {
        playerPosition = gameObject.transform.position;
        isDead = false;


    }
    void OnTriggerEnter2D(Collider2D other)
    {//如果碰到星星
        if (other.gameObject.CompareTag("star"))
        {
            //破壞星星
            other.gameObject.SetActive(false);
            //速度變兩倍
            playerVelocity= playerVelocity*2 ;

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

            playerVelocity = playerVelocity / 2;


        }
    }

    void Update()
    {
        playerPosition.x += Input.GetAxis("Horizontal") * playerVelocity;

        //改變位置
        transform.position = playerPosition;

        //設立邊界

        if (playerPosition.x < -boundaryl)
        {
            transform.position = new Vector3(-boundaryl, playerPosition.y, playerPosition.z);
            playerPosition.x = -boundaryl;
        }   
        if (playerPosition.x > boundaryr)
        {
            transform.position = new Vector3(boundaryr, playerPosition.y, playerPosition.z);
            playerPosition.x = boundaryr;
        }


    }

}
