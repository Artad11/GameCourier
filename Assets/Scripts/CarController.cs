using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider frontLeftWheel;
    public WheelCollider rearLeftWheel;

    public float motorForce = 1000f;
    public float steeringAngle = 30f;

    void Update()
    {
        // Motor input
        float motorInput = Input.GetAxis("Vertical");
        frontLeftWheel.motorTorque = motorInput * motorForce;
        

        // Steering input
        float steeringInput = Input.GetAxis("Horizontal");
        frontLeftWheel.steerAngle = steeringInput * steeringAngle;
        
    }
}