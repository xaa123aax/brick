using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int playerLives;
    public static int playerPoints;
    public Button restartButton;
    public GameObject player;
    public GameObject BALL;


    public Text HP;
    public Text SCORE;

    void Start()
    {
       
                                    
        playerLives = 3;
        playerPoints = 0;
        //剛開始重新開始按鈕不顯示
        restartButton.gameObject.SetActive(false);
    }

    void Hp()
    {

        HP.text = "生命:" + playerLives;
    }
    void Score()
    {

        SCORE.text = "分數:" + playerPoints;
    }

    void Update()
    {
        Hp();
        Score();
        //如果play死了
        if (PlayerScript.isDead)
        {
            player.SetActive(false);
            BALL.SetActive(false);
            restartButton.gameObject.SetActive(true);
        }
    }

    //重新刷新頁面

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  
    }

}



