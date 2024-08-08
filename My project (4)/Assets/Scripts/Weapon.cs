using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform bulletSpwanPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    private AudioSource Shooting_sound;
    // Start is called before the first frame update
    void Start()
    {
        Shooting_sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shooting_sound.Play();
            var bullet = Instantiate(bulletPrefab,bulletSpwanPoint.position,bulletSpwanPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpwanPoint.forward * bulletSpeed ;
        }
    }
}
