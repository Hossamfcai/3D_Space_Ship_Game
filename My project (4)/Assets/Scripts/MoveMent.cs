using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour
{
    public Rigidbody rb;
    public float Forward = 5f;
   
    public float Sideways = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //Move forward
        rb.AddForce(0,0,Forward*Time.deltaTime);
        if (Input.GetKey("w"))
            rb.AddForce(0,Sideways*Time.deltaTime,0,ForceMode.VelocityChange);
        if (Input.GetKey("s"))
            rb.AddForce(0,-Sideways*Time.deltaTime,0,ForceMode.VelocityChange);    
        //Move right    
        else if (Input.GetKey("d"))
            rb.AddForce(Sideways*Time.deltaTime,0,0,ForceMode.VelocityChange);
        //Move left
        else if (Input.GetKey("a"))
            rb.AddForce(-Sideways*Time.deltaTime,0,0,ForceMode.VelocityChange);    

        
    }
}
