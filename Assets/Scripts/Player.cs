using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 6; // скорость игрока
    public float jumpSpeed = 10; ///скорость прыжка
    public float rotationSpeed = 10;
    void Start ()
    {
		
	}
	
	void Update ()
    {
        Move();
	}
    void Move()
    {
        //Получаем значение осей от 1 до - 1
        float moveHorizontal = Input.GetAxis("Horizontal")* speed * Time.deltaTime;
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float moveUp = 0f;
        float rotateHorizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime; // при нажатии клавиши прыжка меняем значение moveUp на скорость прыжка
        if (Input.GetButtonDown("Jump"))
        {
            moveUp = jumpSpeed * Time.deltaTime;
        }
        transform.Rotate(0, rotateHorizontal, 0);
        transform. Translate(moveHorizontal, moveUp, moveVertical); // перемещение
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
