using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerInventory : MonoBehaviour
{
    public int NumberOfDiamonds {get;private set;}
    public UnityEvent<playerInventory>OnDiamondCollected;
    public void DiamondCollected()
    {
        NumberOfDiamonds++;  
        OnDiamondCollected.Invoke(this);  
    }
}
