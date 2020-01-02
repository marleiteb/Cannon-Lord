using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bats : MonoBehaviour
{
   
    public int points;
    public int numberWay;
    public int life;

    private float posX;
    public  float speed;

    public GameObject[] wayBat;

    private void Awake()
    {
       

    }
    void Start()
    {
        
    }


    void Update()
    {
        CompareLife();
        Moviment();


    }

    void CompareLife()
    {
        if (life <= 0)
        {
            GameController.gameC.points += points;
            Destroy(this.gameObject);
        }
    }

    void Moviment()
    {
        if (Vector2.Distance(transform.position, wayBat[numberWay].transform.position) < 0.01f)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                wayBat[numberWay].transform.position, speed * Time.deltaTime);

            numberWay++;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position,
                wayBat[numberWay].transform.position, speed * Time.deltaTime);
        }
        if (Vector2.Distance(transform.position, wayBat[4].transform.position) < 0.01f)
        {
            if (GameController.gameC.points >= 0)
            {
                GameController.gameC.points -= 5;
            }
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);        
            life -= 10;
        }
    }
}
