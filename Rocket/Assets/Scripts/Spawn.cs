using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Met1;
    public GameObject Met2;
    public GameObject Met3;
    public GameObject Arm;
    public GameObject Shild;
    public GameObject Bullet;
    public GameObject Bullet2;
    public GameObject LowTime;
    public bool green = true;
    public static int i = 0;
    public float x1 = 0f;
    public float x2 = 0f;
    public static float cooft = 0f;
    public static int timecof = 1;
   public static int tii = 0;
    public int numbonus = 0;

    void Start()
    {
        StartCoroutine(Spawnm());
    }

    IEnumerator Spawnm()
    {


        while (!Player.lose)
        {

            i++;
            if (i == tii) {
                timecof = 1;
            }

            if (Player.time) {
                Player.time = false;
                tii = (i + 15);
                timecof = 2;
            }

            /// 
            if (i % 25 == 0)
            {

                if (MDown.coof < 7.5)
                {
                    MDown.coof += 0.75f;
                }

                if (cooft < 0.55)
                {
                    cooft += 0.055f;
                }
            }
            if (i % 15 == 0)
            {
                Instantiate(Met2, new Vector2(Random.Range(-2.44f, 2.44f), 6f), Quaternion.identity);
            }

            if (i % 20 == 0)
            {
                numbonus = Random.Range(1, 6);
                switch (numbonus)
                {
                    case 1:
                        {
                            Instantiate(Arm, new Vector2(Random.Range(-2.44f, 2.44f), 6f), Quaternion.identity);
                            break;
                        }
                    case 2:
                        {
                            Instantiate(Shild, new Vector2(Random.Range(-2.44f, 2.44f), 6f), Quaternion.identity);
                            break;
                        }
                    case 3:
                        {
                            Instantiate(Bullet, new Vector2(Random.Range(-2.44f, 2.44f), 6f), Quaternion.identity);
                            break;
                        }
                    case 4:
                        {
                            Instantiate(Bullet2, new Vector2(Random.Range(-2.44f, 2.44f), 6f), Quaternion.identity);
                            break;
                        }
                    case 5:
                        {
                            Instantiate(LowTime, new Vector2(Random.Range(-2.44f, 2.44f), 6f), Quaternion.identity);
                            break;
                        }

                }
            }

            do
            {
                x1 = Random.Range(-2.44f, 2.44f);
            } while (x1 >= (x2 - 1f) && x1 <= (x2 + 1f));
            Instantiate(Met1, new Vector2(x1, 6f), Quaternion.identity);

            if (i > 70)
            {
                do
                {
                    x1 = Random.Range(-2.44f, 2.44f);
                } while (x1 >= (x2 - 1f) && x1 <= (x2 + 1f));
                if (green)
                {
                    Instantiate(Met3, new Vector2(x1, 6f), Quaternion.identity);
                    green = false;
                }
                else
                {
                    green = true;
                }

            }

            yield return new WaitForSeconds((0.8f - cooft)*timecof);
            x2 = x1;
        }
        
    }

}
