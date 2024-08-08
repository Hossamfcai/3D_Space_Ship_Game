using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
  public MoveMent playeMovement;
  public Weapon weapon;
  public GameObject Explosion;
  public GameObject Electricity;
  public GameObject player;

  public GameManager gameManager;
  public AudioSource ExplosionSound;
  private float LifeTime = 1;
 
  
  void OnCollisionEnter(Collision collisionInfo)
  {
    if((collisionInfo.collider.tag == "Ground") || (collisionInfo.collider.tag == "Glass") || (collisionInfo.collider.tag == "Obstcales") || (collisionInfo.collider.tag == "Cube"))
    {
        ExplosionSound.Play();
        GameObject explosionFire = Instantiate(Explosion,transform.position,Quaternion.identity);
        Destroy(explosionFire,LifeTime);
        Invoke("DestroyPlayer",LifeTime);

        playeMovement.enabled = false;
        weapon.enabled = false;
        gameManager.GameOverDelay();
    }
     if(collisionInfo.collider.tag =="Electricity")
    {
        ExplosionSound.Play();
        GameObject electricity_Shock = Instantiate(Electricity,transform.position,Quaternion.identity);
        Destroy(electricity_Shock,LifeTime);
        Invoke("DestroyPlayer",LifeTime);

        playeMovement.enabled = false;
        weapon.enabled = false;
        gameManager.GameOverDelay();
    }

  }
  void DestroyPlayer()
  {
    player.SetActive(false);
  }
}
