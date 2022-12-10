using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleJump : state
{
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
        if (heroine.onGround == true)
        {
            heroine.Transition(new standing());
        }
    }
}
