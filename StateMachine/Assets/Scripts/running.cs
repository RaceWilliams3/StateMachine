using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class running : state
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
        heroine.GetComponent<Rigidbody>().AddForce(new Vector3(1 * direction, 0, 0));
        if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
        {
            heroine.Transition(new standing());
        }

        if (Input.GetKeyDown("left shift"))
        {
            heroine.Transition(new sprinting(direction));
        }
    }
    
    public running(int direction)
    {
        this.direction = direction;
    }
}
