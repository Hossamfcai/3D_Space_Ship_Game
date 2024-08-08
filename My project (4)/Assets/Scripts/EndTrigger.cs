using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameObject playerBody;
    public GameManager gameManager;
    public GameObject ScoreText;
    public float LifeTime = 1f;
   void OnTriggerEnter(Collider collider)
   {
     if(collider.tag=="Player")
     {
        gameManager.LevelComplete();
        ScoreText.SetActive(false);
        gameManager.Sound();  
        Invoke("DestroyPlayer",LifeTime);
     }
   }
     void DestroyPlayer()
  {
    playerBody.SetActive(false);
  }

}
