using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HScore : MonoBehaviour
{
    [SerializeField]
    private TextMesh scoreLabel;
    public static int Hscore;

    void Start()
    {
        Hscore = PlayerPrefs.GetInt("Hscore");
        scoreLabel.text = "HIGHT SCORE\n\n         " + Hscore;
    }
}
