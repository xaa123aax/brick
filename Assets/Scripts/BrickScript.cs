using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickScript : MonoBehaviour
{
    public int hitsToKill;
    public int points;
    private int numberOfHits;
    int starcolor;
    public static int bricksbreak=0;
  

    void Start()
    {
        numberOfHits = 0;
  

    }
    //產生紅星星
    void SpawnStar()
    {
        GameObject newStar = Instantiate(Resources.Load<GameObject>("bonus"));
        newStar.transform.position = gameObject.transform.position;

    }
    //產生黃星星
    void SpawnStar2()
    {
        GameObject newStar2 = Instantiate(Resources.Load<GameObject>("bonus2"));
        newStar2.transform.position = gameObject.transform.position;
  
    }
    //產生綠星星
    void SpawnStar3()
    {
        GameObject newStar3 = Instantiate(Resources.Load<GameObject>("bonus3"));
        newStar3.transform.position = gameObject.transform.position;
     
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //如果碰到球
        if (other.gameObject.CompareTag("ball"))
        {
            //計數加1
            numberOfHits++;
            //如果計數等於磚塊死亡撞擊數
            if (numberOfHits == hitsToKill)
            {
                // 破壞磚塊
                gameObject.SetActive(false);
                //加分
                GameManager.playerPoints += points;
                //破壞數+1
                bricksbreak = bricksbreak + 1;
                Debug.Log(bricksbreak);
                Debug.Log(CreateBrick.colormax);
              
                //破壞了12個
                if (bricksbreak == 12)
                {
                    //破壞數重製
                    bricksbreak = bricksbreak - 12;
                    //刷新頁面
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
                //如果計數>0
                if (numberOfHits > 0)
                {
                    //星星隨機
                    starcolor = Random.Range(1, 4);
                    switch (starcolor)
                    {
                        case 1:
                            SpawnStar();
                            break;
                        case 2:
                            SpawnStar2();
                            break;
                        case 3:
                            SpawnStar3();

                            break;

                        default:

                            break;

                    }

                }
            }

        }

    }

}

                   