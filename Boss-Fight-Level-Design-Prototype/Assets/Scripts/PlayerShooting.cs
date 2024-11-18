using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GameObject bulletClone = (GameObject)Instantiate(bulletPrefab, shotPoint.transform.position, shotPoint.transform.rotation);
            bulletClone.transform.localScale = transform.localScale;
        }
    }
}
