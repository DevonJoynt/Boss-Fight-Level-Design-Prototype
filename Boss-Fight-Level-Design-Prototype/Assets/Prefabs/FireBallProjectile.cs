using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallProjectile : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform FirePoint;
    public float bulletSpeed = 50f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Assuming left mouse button or similar
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        bullet.transform.parent = null; // Ensure it's not attached to the gun

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = FirePoint.right * bulletSpeed; // Move the bullet forward
    }
}