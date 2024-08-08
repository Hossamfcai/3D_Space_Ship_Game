using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public MoveMent player;
    public Rigidbody rb; 
    public GameObject playerBody;
    public GameObject Explosion;
    public GameManager gameManager;
    public AudioSource ExplosionSound;
    private float LifeTime = 1f;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
      
      if(collider.tag != "Bullet")
      {
        ExplosionSound.Play();
        GameObject explosionFire = Instantiate(Explosion,playerBody.transform.position,Quaternion.identity);
        Destroy(explosionFire,LifeTime);
        Invoke("DestroyPlayer",LifeTime/2f);
            player.enabled = false; 
            rb.AddForce(0,-8000,0);
            gameManager.GameOverDelay();
      }
    }
     void DestroyPlayer()
  {
    playerBody.SetActive(false);
  }

}
