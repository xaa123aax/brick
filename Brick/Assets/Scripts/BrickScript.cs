using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int hitsToKill;
    public int points;
    private int numberOfHits;
     int starcolor;



    void Start()
    {
        numberOfHits = 0;
  

    }
    void SpawnStar()
    {
        GameObject newStar = Instantiate(Resources.Load<GameObject>("bonus"));
        newStar.transform.position = this.gameObject.transform.position;

    }
    void SpawnStar2()
    {
        GameObject newStar2 = Instantiate(Resources.Load<GameObject>("bonus2"));
        newStar2.transform.position = this.gameObject.transform.position;
  
    }
    void SpawnStar3()
    {
        GameObject newStar3 = Instantiate(Resources.Load<GameObject>("bonus3"));
        newStar3.transform.position = this.gameObject.transform.position;
     
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("ball"))
        {
            numberOfHits++;

            if (numberOfHits == hitsToKill)
            {
                // 破壞磚塊
                this.gameObject.SetActive(false);
                GameManager.playerPoints += points;
                if (numberOfHits > 0)
                {
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

                   