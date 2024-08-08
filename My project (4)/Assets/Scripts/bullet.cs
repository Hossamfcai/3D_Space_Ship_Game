using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
  public float life = 3f;
  public GameObject hitEffect;

  void OnCollisionEnter(Collision collision)
  {

     if(collision.collider.tag == "Glass" || collision.collider.tag == "Cube")
    {
          
          GameObject effect = Instantiate(hitEffect,transform.position,Quaternion.identity);
          Destroy(effect,life);
          Destroy(gameObject);
          Destroy(collision.gameObject);

         // Destroy(gameObject);
    }
    

  }

    
 
    
  
  
}

//  void Awake()
//   {
//     Destroy(gameObject , life);
//   }
//   void OnCollisionEnter(Collision collision)
//   {
//     if(collision.collider.tag == "Glass")
//     {
//           Destroy(collision.gameObject);
//           Destroy(gameObject);
//     }
