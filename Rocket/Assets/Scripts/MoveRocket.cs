using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour
{

    public Transform player;
    public Transform player2;

    [SerializeField]
    private float speed = 10f;

    void OnMouseDrag()
    {
         if (!Player.lose)
            {

                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePos.x = mousePos.x > 2.35f ? 2.35f : mousePos.x;
                mousePos.x = mousePos.x < -2.35f ? -2.35f : mousePos.x;
                player.position = Vector2.MoveTowards(player.position, new Vector2(mousePos.x, player.position.y), speed * Time.deltaTime);
                player2.position = Vector2.MoveTowards(player2.position, new Vector2(mousePos.x, player2.position.y), speed * Time.deltaTime);
            }
    }   
 }
