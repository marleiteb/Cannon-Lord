using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public static Cannon canon;

    public GameObject cannon;
    public GameObject bulletPrefab;

    public Transform localSpawnBullet;

    public bool canShoot;

    public float countdown;
    public float zPosition;
    public float speed;
    public float bulletForce;

    private void Awake()
    {
        canon = this;
    }
    void Start()
    {
        bulletForce = 15f;
        zPosition = 0;
        speed = 0f;
        canShoot = true;
    }

  
    void Update()
    {
        CannonMoviment();

        if ((Input.GetMouseButtonDown(0) || Input.touchCount == 1) && canShoot)
        {
            Shoot();
        }

        if (!canShoot)
        {
            countdown += Time.deltaTime;
        }

        if (countdown >= 0.7f)
        {
            canShoot = true;
            countdown = 0;
        }

    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, localSpawnBullet.transform.position, localSpawnBullet.transform.rotation);
        Rigidbody2D rig = bullet.GetComponent<Rigidbody2D>();
        rig.GetComponent<Rigidbody2D>().AddForce(localSpawnBullet.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet.gameObject, 2);
        canShoot = false;

    }

    void CannonMoviment()
    {
        cannon.transform.eulerAngles = new Vector3(0, 0, zPosition);

        zPosition += speed;

        if (zPosition >= 45)
        {
            speed *= -1;
        }
        else if (zPosition <= -45)
        {
            speed *= -1;
        }

    }
}
