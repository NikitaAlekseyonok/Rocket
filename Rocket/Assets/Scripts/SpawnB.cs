using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnB : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Button;
    public Transform player;
    void Update()
    {
            foreach (Touch touch in Input.touches) //Для каждого прикосновения к экрану (ибо можно положить одновременно два пальца)
            {
         
                if (touch.phase == TouchPhase.Began) //Если фаза прикосновения "Прикоснулся" (т.е. как только тыкнул в экран)
                {
                    Ray ray = Camera.main.ScreenPointToRay(touch.position); //Создаем луч в точке прикосновения
                    RaycastHit hit; //Регистрируем переменную, в которой будет инфа о предмете, в который мы попали
                    Physics.Raycast(ray, out hit); //Выпускаем луч и записываем всю инфу в hit
                    if (hit.collider == Button.GetComponent<Collider>()) //Если мы попали в объект, на котором висит этот скрипт
                    {

                    }
                
            }
        }
    }
}
  

