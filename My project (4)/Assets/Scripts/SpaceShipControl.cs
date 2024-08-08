using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipControl : MonoBehaviour
{
    public bool throttle => Input.GetKey(KeyCode.Space);
    public float pitchPower , rollPower , yawPower , enginePower;
    private float activeRoll,activePitch,activeYaw;
    ////////////////////////////////////////////////////////////////////////////////////////////////
    //public float forwardSpeed =25f, strafeSpeed = 7.5f , hoverSpeed = 5f;
   // private float activeForwardSpeed , activeStrafeSpeed , activeHoverSpeed;
    //private float forwardAcceleration = 2.5f , starfeAcceleration = 2f , hoverAcceleration = 2f;
    //public float lookRotate = 90f;
    //private Vector2 lookInput,screenCenter,mouseDistance ;
    //private float rollInput;
    //public float rollSpeed = 90f , rollAcceleration = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        // screenCenter.x = Screen.width * .5f;
        // screenCenter.y = Screen.height * .5f;

    }

    // Update is called once per frame
    void Update()
    {
        if(throttle)
        {
            transform.position += transform.forward * enginePower * Time.deltaTime;
            activePitch = Input.GetAxisRaw("Vertical") * pitchPower * Time.deltaTime;
            activeRoll = Input.GetAxisRaw("Horizontal") * rollPower * Time.deltaTime;
            activeYaw = Input.GetAxisRaw("Hover") * yawPower * Time.deltaTime;

            transform.Rotate(activePitch*pitchPower*Time.deltaTime,activeYaw * yawPower *Time.deltaTime,-activeRoll*rollPower*Time.deltaTime,Space.Self);

        }
        else
        {
                
            activePitch = Input.GetAxisRaw("Vertical") * pitchPower/2 * Time.deltaTime;
            activeRoll = Input.GetAxisRaw("Horizontal") * rollPower /2* Time.deltaTime;
            activeYaw = Input.GetAxisRaw("Hover") * yawPower/2 * Time.deltaTime;

            transform.Rotate(activePitch*pitchPower*Time.deltaTime,activeYaw * yawPower *Time.deltaTime,-activeRoll*rollPower*Time.deltaTime,Space.Self);
        }
    //     lookInput.x = Input.mousePosition.x;
    //     lookInput.y = Input.mousePosition.y;

    //     mouseDistance.x = (lookInput.x - screenCenter.x)/screenCenter.y;
    //     mouseDistance.y = (lookInput.y - screenCenter.y)/screenCenter.y;

    //     mouseDistance = Vector2.ClampMagnitude(mouseDistance , 1f);

    //     rollInput = Mathf.Lerp(rollInput , Input.GetAxisRaw("Roll"),rollAcceleration * Time.deltaTime);

    //     transform.Rotate(-mouseDistance.y * lookRotate * Time.deltaTime , mouseDistance.x * lookRotate * Time.deltaTime,rollInput*Time.deltaTime,Space.Self);

    //     activeForwardSpeed = Mathf.Lerp(activeForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed , forwardAcceleration * Time.deltaTime);
    //     activeStrafeSpeed =Mathf.Lerp(activeStrafeSpeed, Input.GetAxisRaw("Horizontal") * strafeSpeed,starfeAcceleration * Time.deltaTime);
    //     activeHoverSpeed =Mathf.Lerp(activeHoverSpeed, Input.GetAxisRaw("Hover") * hoverSpeed,hoverAcceleration * Time.deltaTime);

    //     transform.position += transform.forward * activeForwardSpeed *Time.deltaTime;
    //     transform.position += (transform.right * activeStrafeSpeed *Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);

     }
}
