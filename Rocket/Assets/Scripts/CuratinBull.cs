using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuratinBull : MonoBehaviour
{

    public int k = 0;
    public GameObject Pulka;
    public GameObject Roc;

    void Start()
    {
        StartCoroutine(Bull());
    }

    IEnumerator Bull()
    {
        while (!Player.lose)
        {

            if (Player.pulki != 0)
            {
                if (k == 1)
                {
                    Instantiate(Pulka, new Vector2(Roc.transform.position.x, Roc.transform.position.y), Quaternion.identity);
                    k = 0;
                    Player.pulki--;
                }
                k++;
            }
            yield return new WaitForSeconds(0.5f);
        }
    }
}