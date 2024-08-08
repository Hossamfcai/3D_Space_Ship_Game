using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCube : MonoBehaviour
{
  public Rigidbody rb;
  public GameObject ExplosionBody;
  public GameObject ExplosionEffect;
  public GameObject ExplosionSound;
  public float LifeTime = 1f;
  void OnCollisionEnter(Collision collisionInfo)
  {
        if(collisionInfo.collider.tag == "Bullet")
        {
            ExplosionSound.SetActive(true);
            rb.AddForce(0,5000,0);
            GameObject Explosion = Instantiate(ExplosionEffect,ExplosionBody.transform.position,Quaternion.identity);
            Destroy(Explosion,LifeTime);
            Invoke("DestroyCube",LifeTime);
        }
  }
  void DestroyCube()
  {
    // ExplosionBody.SetActive(false);
    ExplosionSound.SetActive(false);
  }
}
