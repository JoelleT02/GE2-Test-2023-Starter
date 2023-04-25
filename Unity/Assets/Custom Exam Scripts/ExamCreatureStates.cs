using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PlayerControlState: State
{
    public override void Enter()
    {
        owner.GetComponent<PlayerSteering>().enabled = true;
        GameObject.FindObjectOfType<FollowCamera>().enabled = true;
    }

    public override void Think()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            owner.RevertToPreviousState();
        }
    }

    public override void Exit()
    {
        owner.GetComponent<PlayerSteering>().enabled = false;
        GameObject.FindObjectOfType<FollowCamera>().enabled = false;
    }
}

class SeekState: State
{
    public override void Enter()
    {
        owner.GetComponent<NoiseWander>().enabled = true;
        owner.GetComponent<Harmonic>().enabled = true;
        owner.GetComponent<Seek>().enabled = true;
        GameObject.FindObjectOfType<FPSController>().enabled = true;
    }

    public override void Think()
    {
        
    }

    public override void Exit()
    {
        owner.GetComponent<NoiseWander>().enabled = false;
        owner.GetComponent<Harmonic>().enabled = false;
        owner.GetComponent<Seek>().enabled = false;
        GameObject.FindObjectOfType<FPSController>().enabled = false;
    }
}
