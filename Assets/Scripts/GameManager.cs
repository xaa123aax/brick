﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int playerLives;
    public static int playerPoints;
    public Button restartButton;
    public Button restartButton2;
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
        restartButton2.gameObject.SetActive(false);
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
        if (GameStatus.Instance.now == GameStatus.Status.Stop)
        {
            player.SetActive(false);
            BALL.SetActive(false);
            restartButton.gameObject.SetActive(true);
            restartButton2.gameObject.SetActive(true);

        }
        //如果按下r 刷新當前關卡
        if (Input.GetKeyDown(KeyCode.R))
        {
            CreateBrick.colormax = CreateBrick.colormax-1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            BrickScript.bricksbreak = 0;
        }
        //如果按下w 刷新所有關卡
        if (Input.GetKeyDown(KeyCode.W))
        {
            CreateBrick.colormax = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            BrickScript.bricksbreak = 0;
        }
    }






    //重新刷新頁面

    public void ReloadScene()
    {
        CreateBrick.colormax = CreateBrick.colormax - 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        BrickScript.bricksbreak = 0;
    }

    public void ReloadAllScene()
    {
        CreateBrick.colormax = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        BrickScript.bricksbreak = 0;
    }

}



