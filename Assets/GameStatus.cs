using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    public enum Status { Menu, Play, Stop, NextLevel };

    public static GameStatus Instance = null;

    //public static GameStatus Instance = null;

    [Header("目前的遊戲狀態")]
    public Status now;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(this.gameObject);
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
    }

    void Update()
    {
        switch (now)
        {
            case Status.Menu:
          
                break;
            case Status.Play:
               
              
                break;
            case Status.Stop:
               
                         
                break;
            case Status.NextLevel:
                
                now = Status.Play;
                break;
        }
    }
}
