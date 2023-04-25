using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<StateMachine>().ChangeState(new SeekState());
    }
}
