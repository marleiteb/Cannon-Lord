using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rig;

    public float speed;

    Cannon cannon;
  
    void Start()
    {
        //Destroy(this.gameObject, 2f);

    }

   
    void Update()
    {
        //transform.Translate(Vector2.up * speed);

        //rig.AddForce(cannon.localSpawnBullet.up * speed , ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("stone"))
        {
            Destroy(this.gameObject);
        }
    }

}
