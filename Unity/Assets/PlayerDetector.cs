using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("MainCamera")) return;
        GetComponentInParent<StateMachine>().ChangeState(new PlayerControlState());
        other.GetComponent<FPSController>().enabled = false;
        other.GetComponent<FollowCamera>().enabled = true;
    }
}
