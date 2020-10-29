using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MDownB : MonoBehaviour
{
    [SerializeField]
    public float speed = 10f;

    void Update()
    {
       
            if (transform.position.y > 7f)
            {
                Destroy(gameObject);
            }
            transform.position += new Vector3(0, speed * Time.deltaTime);
        
    }
}
