using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{


    void OnMouseDown()
    {
        SceneManager.LoadScene("main");
        Spawn.i = 0;
        Txt.score = 0;
        MDown.coof = 0;
        Spawn.cooft = 0;
        Player.pulki = 0;
        Spawn.tii = 0;

    }
}
