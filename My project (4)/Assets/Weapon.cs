using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_1 : MonoBehaviour
{
    public Transform bulletSpwanPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(bulletPrefab,bulletSpwanPoint.position,bulletSpwanPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(bulletSpwanPoint.up*bulletSpeed,ForceMode.Impulse);
        }
    }
}
