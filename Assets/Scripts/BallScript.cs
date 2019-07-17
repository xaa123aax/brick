using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    private bool ballIsActive;
    private Vector3 ballPosition;
    private Vector2 ballInitialForce;
    private Vector2 ballInitialForcesmall, ballInitialForcesmall2;
    public GameObject playerObject;
    public static int ballbreaknumber1;
    public static int ballbreaknumber2;
    private float waitTime = 20.0f;
    public static float timer = 0.0f;
    private AudioSource sound;
    public AudioClip hit;


    void Start()
    {
        sound = gameObject.AddComponent<AudioSource>();
        //給球一個初始的力量使遊戲開始
        ballInitialForce = new Vector2(100.0f, 300.0f);
        ballInitialForcesmall = new Vector2(300.0f, -300.0f);
        ballInitialForcesmall2 = new Vector2(-300.0f, -300.0f);
        //活性一開始為 false
        ballIsActive = false;

        //球的位置
        ballPosition = transform.position;
    }
    void OnCollisionEnter2D(Collision2D other)

    {
        sound.PlayOneShot(hit);
    }
        void OnTriggerEnter2D(Collider2D other)
    {//如果碰到星星
        sound.PlayOneShot(hit);
        if (other.gameObject.CompareTag("bonus1"))
        {
            //破壞星星
            other.gameObject.SetActive(false);
            //速度變兩倍
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity * 2;
        }
        if (other.gameObject.CompareTag("bonus2"))
        {
            //破壞星星
            other.gameObject.SetActive(false);
            transform.localScale += new Vector3(0.5f, 0.5f, 0);
            //大小變1.2倍

        }
        if (other.gameObject.CompareTag("bonus3"))
        {
            //破壞星星
            other.gameObject.SetActive(false);
            //速度變1/2倍
            GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity / 2;

        }
        if (other.gameObject.CompareTag("bonus4"))
        {
            //破壞星星
            other.gameObject.SetActive(false);
            transform.localScale -= new Vector3(0.2f, 0.2f, 0);
            //大小變0.8倍

        }
        if (other.gameObject.CompareTag("bonus5"))
        {
            //破壞星星
            other.gameObject.SetActive(false);


        }
        if (other.gameObject.CompareTag("boss"))
        {

           
            //破壞星星
            GameManager.bossHp--;

            if (GameManager.bossHp <= 0)
            {
                other.gameObject.SetActive(false);


            }
           



}



    }

    void Update()
    {
        // 空白建噴射球
        if (Input.GetButtonDown("Jump") == true)
        {
            //時間歸0
            timer = 0;
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
            ballPosition.y = playerObject.transform.position.y + 0.5f;

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
            transform.localScale = Vector3.one;

            //把速度給歸0
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;


            GameManager.playerLives--;
            //如果小於等於0 isDead為真
            if (GameManager.playerLives <= 0)
            {

                GameStatus.Instance.now = GameStatus.Status.Stop;
            }

        }




        //時間每幀增加
        timer += Time.deltaTime;

 

        //如果時間大於等待時間

        if (timer > waitTime )
        {
            //讓檢察2去等於當前打破數量
            ballbreaknumber2 = BrickScript.bricksbreak;
            //把時間歸0
            timer = timer - waitTime;
            //如果檢查1等於檢查2
            if ( ballPosition.x > 0)
            {
                //再給予他一個小的力量讓他偏移                 
                GetComponent<Rigidbody2D>().AddForce(ballInitialForcesmall2);

            }
            if ( ballPosition.x < 0)
            {
                //再給予他一個小的力量讓他偏移                 
                GetComponent<Rigidbody2D>().AddForce(ballInitialForcesmall);

            }

        }






    }
}
