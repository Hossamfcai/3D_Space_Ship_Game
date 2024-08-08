using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamonds : MonoBehaviour
{
    public AudioSource DiamondSound;
    private void OnTriggerEnter(Collider other)
    {
        playerInventory playerInventory = other.GetComponent<playerInventory>();
        if(playerInventory != null)
        {
            DiamondSound.Play();
            playerInventory.DiamondCollected();
            gameObject.SetActive(false);
        }
    }
}
