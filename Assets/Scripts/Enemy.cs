using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 20f; // Общедоступная переменная скорости 
    public float rotationSpeed = 10;
    public float movingDistance = 8; //До какого расстояния дойдет обьект по X
    public bool randomSpeed;
    public float maxSpeed = 16;
	void Start ()
    {
       if (randomSpeed)
        {
            speed = Random.Range(1, 16);
        }
	}

	void Update ()
    {
        // Если положение обьекта больше равен MovingDistance поворачиваем
        if (transform.position.x >= movingDistance || transform.position.x <= -movingDistance)   
        {
            speed = -speed;
        }
        

        transform.Translate(speed * Time.deltaTime, 0, 0); // Передвигает обьект
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0); //Вращает обьект
    }
}
