using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBonus : MonoBehaviour
{
    [SerializeField]
    public float speed = 3f;

    void Update()
    {
       
            if (transform.position.y < -6f || Player.takeBonus1 || Player.takeBonusShild || Player.pulki != 0 || Player.time)
            {
                Destroy(gameObject);
                Player.takeBonusShild = false;
            }
            transform.position -= new Vector3(0, speed * Time.deltaTime);
        
    }
}

