using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBrick : MonoBehaviour
{
    public int color;
    public List<Transform> bricks;
    public static int colormax =1;

    void Start()
    {   
        colormax = colormax + 1;
        bricks = new List<Transform>();
        for (int i = 0; i < 12; i++)
        {
            color = Random.Range(1, colormax);
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
    float BrickPositionX()
    {
        if (bricks.Count == 0)
        {
            return 0;
        }
        return Mathf.Floor(bricks.Count /4  )*3;
    }
    float BrickPositionY()
    {
        if (bricks.Count == 0)
        {
            return 0;
        }
        return bricks.Count % 4;
    }

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