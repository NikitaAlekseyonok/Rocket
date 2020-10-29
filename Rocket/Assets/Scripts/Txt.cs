using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Txt : MonoBehaviour
{
    [SerializeField]
    private TextMesh scoreLabel;
    public static int score = 0;

    void Update()
    {
        scoreLabel.text = "SCORE: " + score;
    }
}
