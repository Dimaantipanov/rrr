using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Ball acceleration.
    public int Acceleration=5;
    //ball direction.
    public Vector3 MoveBall;
    public Rigidbody RigBod;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            MotionBall();
        }

      

    }
    void MotionBall() { RigBod.AddForce(MoveBall.normalized * Acceleration, ForceMode.Impulse); }
}
