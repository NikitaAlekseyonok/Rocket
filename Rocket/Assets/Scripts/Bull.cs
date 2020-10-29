using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bull : MonoBehaviour
{
    public static bool kill = false;
    public static float boomx;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Met")
        {
            kill = true;
            boomx = transform.position.x;
            Destroy(gameObject);
        }
    }
}