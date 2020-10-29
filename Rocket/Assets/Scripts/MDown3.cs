using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDown3 : MonoBehaviour
{
  
    [SerializeField]
    private float fallspeed1 = 3f;

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
                Txt.score += 3;
            }
            if (Player.kill == true && (transform.position.x <= (Player.plx + 0.8) && transform.position.x >= (Player.plx - 0.8)))
            {
                Destroy(gameObject);
                Player.kill = false;
            }

            if (transform.position.y < -6f)
            {

                Destroy(gameObject);
                if (!Player.lose)
                {
                    Txt.score++;
                }
            }
            transform.position -= new Vector3(0, ((fallspeed1 + MDown.coof)/ Spawn.timecof) * Time.deltaTime);
        
    }
}
