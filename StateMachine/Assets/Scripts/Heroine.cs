using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroine : MonoBehaviour
{
    private state currentState = new standing();
    public bool onGround = true;

    public void Transition(state newState)
    {
        currentState.exit(this);
        currentState = newState;
        currentState.entry(this);
    }

    void Start()
    {

    }

    void Update()
    {
        currentState.Update(this);
    }

    void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

}
