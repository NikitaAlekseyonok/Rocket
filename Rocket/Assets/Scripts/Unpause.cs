using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unpause : MonoBehaviour
{
    public GameObject Buttonmini;
    public GameObject Buttonbig;


    void OnMouseDown()
    {
        Time.timeScale = 1;
        Buttonmini.SetActive(true);
        Buttonbig.SetActive(false);
    }
}