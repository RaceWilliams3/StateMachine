using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : state
{
    private Heroine heroine;

    public void entry(Heroine heroine)
    {
        heroine.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        heroine.onGround = false;
    }

    public void exit(Heroine heroine)
    {

    }

    public void Update(Heroine heroine)
    {
        if (Input.GetKeyDown("s"))
        {
            heroine.Transition(new diving());
        }

        if (Input.GetKeyDown("w"))
        {
            heroine.Transition(new doubleJump());
        }

        if (heroine.onGround == true)
        {
            heroine.Transition(new standing());
        }

    }
}