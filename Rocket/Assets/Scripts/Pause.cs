using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject Buttonmini;
    public GameObject Buttonbig;

    void OnMouseDown()
    {
        Time.timeScale = 0;
        Buttonmini.SetActive(false);
        Buttonbig.SetActive(true);

    }
}
