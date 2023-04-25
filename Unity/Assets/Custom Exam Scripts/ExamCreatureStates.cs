using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class PlayerControlState: State
{
    public override void Enter()
    {
        owner.GetComponent<PlayerSteering>().enabled = true;
    }

    public override void Think()
    {
        base.Think();
    }

    public override void Exit()
    {
        owner.GetComponent<PlayerSteering>().enabled = true;
    }
}

class SeekState: State
{
    public override void Enter()
    {
        owner.GetComponent<NoiseWander>().enabled = true;
        owner.GetComponent<Harmonic>().enabled = true;
        owner.GetComponent<Seek>().enabled = true;
    }

    public override void Think()
    {
        
    }

    public override void Exit()
    {
        owner.GetComponent<NoiseWander>().enabled = false;
        owner.GetComponent<Harmonic>().enabled = false;
        owner.GetComponent<Seek>().enabled = false;
    }
}
