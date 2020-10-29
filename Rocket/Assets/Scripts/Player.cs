using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject restart;
    public GameObject player1;
    public GameObject player2;
    public GameObject HScore;
    public GameObject Buttonmini;
    public static bool lose = false;
    public static bool takeBonus1 = false;
    public static bool takeShild = false;
    public static bool takeBonusShild = false;
    public static bool kill = false;
    public static float plx;
    public static int  pulki = 0;
    public static bool time = false;

    void Awake() {
        lose = false;  
        Buttonmini.SetActive(true);
    }
    
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Shild")
        {
            player1.SetActive(false);
            player2.SetActive(true);
            takeShild = true;
            takeBonusShild = true;
        }

        if (other.gameObject.tag == "Bul1")
        {
            pulki ++;
        }

        if (other.gameObject.tag == "Bul2")
        {
            pulki+=2;
        }

        if (other.gameObject.tag == "Bonus") {

            takeBonus1 = true;
        }

        if (other.gameObject.tag == "Time")
        {
           time = true;
        }

        if (other.gameObject.tag == "Met") {
            if (takeShild) {
                plx = player2.transform.position.x;
                kill = true;
                player1.SetActive(true);
                player2.SetActive(false);
                takeShild = false;
            }
            else if(!takeShild)
            {
                lose = true;
                Buttonmini.SetActive(false);
                restart.SetActive(true);
                if (PlayerPrefs.GetInt("Hscore") < Txt.score)
                {
                    PlayerPrefs.SetInt("Hscore", Txt.score);
                }
                HScore.SetActive(true);
            }
        }
    }
    }

