using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSteering : SteeringBehaviour
{
    public float steeringForce;

    public override Vector3 Calculate()
    {
        Vector3 force = Vector3.zero;

        force += Input.GetAxis("Vertical") * transform.forward * steeringForce;

        Vector3 projectedRight = transform.right;
        projectedRight.y = 0;
        projectedRight.Normalize();

        force += Input.GetAxis("Horizontal") * projectedRight * steeringForce * 0.2f;

        return force;
    }
}
