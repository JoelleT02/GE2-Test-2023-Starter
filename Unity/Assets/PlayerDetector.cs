using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public FPSController fps;
    public FollowCamera follow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            fps.enabled = false;
            follow.enabled = true;
        }
    }
}
