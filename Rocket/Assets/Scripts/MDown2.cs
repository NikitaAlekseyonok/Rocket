using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDown2 : MonoBehaviour
{
    public GameObject Met2;

    [SerializeField]
    public float fallspeed2 = 16.5f;
    void Update()
    {
       
            if (Bull.kill == true && (transform.position.x <= (Bull.boomx + 0.6) && transform.position.x >= (Bull.boomx - 0.6)))
            {
                Destroy(gameObject);
                Bull.kill = false;
                Txt.score += 5;
            }

            if (Player.takeBonus1 == true)
            {
                var ObjectBonus1 = GameObject.FindGameObjectsWithTag("Met");
                for (int i = 0; i < ObjectBonus1.Length; i++)
                {
                    Destroy(ObjectBonus1[i]);
                }
                Player.takeBonus1 = false;

            }

            if (Player.kill == true && (transform.position.x <= (Player.plx + 0.8) && transform.position.x >= (Player.plx - 0.8)))
            {
                Destroy(gameObject);
                Player.kill = false;
            }

            if (transform.position.y < -6f)
            {
                if (!Player.lose)
                {
                    Txt.score++;
                }
                Destroy(gameObject);

            }

            transform.position -= new Vector3(0, ((fallspeed2) / Spawn.timecof) * Time.deltaTime);
        
    }
}
