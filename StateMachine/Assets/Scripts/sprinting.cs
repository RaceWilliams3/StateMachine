using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprinting : state
{
    private int direction;

    public void entry(Heroine heroine)
    {

    }

    public void exit(Heroine heroine)
    {

    }

    public void Update(Heroine heroine)
    {
        if (Input.GetKeyUp("left shift"))
        {
            heroine.Transition(new running(direction));
        }

        if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            heroine.Transition(new standing());
        }

        heroine.GetComponent<Rigidbody>().AddForce(new Vector3(2 * direction, 0, 0));
    }

    public sprinting(int direction)
    {
        this.direction = direction;
    }
}
