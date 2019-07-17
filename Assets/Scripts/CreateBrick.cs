using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBrick : MonoBehaviour
{
    public int color;
    public List<Transform> bricks;
    //設定磚塊等級最大值
    public static int colormax = 1;


    void Start()
    {
       
        //磚塊等級最大值+1
        colormax = colormax + 1;
        //設一個序列
        bricks = new List<Transform>();
        //產生方塊
        if (colormax < 6)
        {
            for (int i = 0; i < 12; i++)
            {
                //隨機選擇介於1至最大值
                color = Random.Range(1, colormax);
                //選擇產生的
                switch (color)
                {
                    case 1:
                        SpawnBrick();
                        break;
                    case 2:
                        SpawnBrick2();
                        break;
                    case 3:
                        SpawnBrick3();
                        break;
                    case 4:
                        SpawnBrick4();
                        break;
                    default:
                        SpawnBrick4();
                        break;

                }
            }

        }
        if (colormax >= 6)
        {
            GameObject newBoss = Instantiate(Resources.Load<GameObject>("boss"));
            newBoss.transform.position = Vector2.zero;
        }
    }
    //選擇x的位置
    float BrickPositionX()
    {
        //如果是計數0 回到0
        if (bricks.Count == 0)
        {
            return 0;
        }
        //否則回到計數/4的無條件捨去整數*3
        return Mathf.Floor(bricks.Count / 4) * 3;
    }
    //選擇y的位置
    float BrickPositionY()
    {
        //如果是計數0 回到0
        if (bricks.Count == 0)
        {
            return 0;
        }
        //否則回到計數取4的餘數
        return bricks.Count % 4;
    }
    //產生方塊
    void SpawnBrick()
    {
        GameObject newBrick = Instantiate(Resources.Load<GameObject>("redbrick"));
        newBrick.transform.position = new Vector2(BrickPositionX(), BrickPositionY());
        bricks.Add(newBrick.transform);

    }
    void SpawnBrick2()
    {
        GameObject newBrick2 = Instantiate(Resources.Load<GameObject>("yellowbrick"));
        newBrick2.transform.position = new Vector2(BrickPositionX(), BrickPositionY());
        bricks.Add(newBrick2.transform);

    }
    void SpawnBrick3()
    {
        GameObject newBrick3 = Instantiate(Resources.Load<GameObject>("greenbrick"));
        newBrick3.transform.position = new Vector2(BrickPositionX(), BrickPositionY());
        bricks.Add(newBrick3.transform);

    }
    void SpawnBrick4()
    {
        GameObject newBrick4 = Instantiate(Resources.Load<GameObject>("bluebrick"));
        newBrick4.transform.position = new Vector2(BrickPositionX(), BrickPositionY());
        bricks.Add(newBrick4.transform);
    }


}