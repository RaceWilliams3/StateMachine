using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standing : state
{

    public void entry(Heroine heroine)
    {
    }

    public void exit(Heroine heroine)
    {
    }

    public void Update(Heroine heroine)
    {
        if (Input.GetKeyDown("w"))
        {
            heroine.Transition(new jump());
        }
        if (Input.GetKeyDown("s"))
        {
            heroine.Transition(new ducking());
        }
        if (Input.GetKeyDown("a"))
        {
            heroine.Transition(new running(-1));
        }
        if (Input.GetKeyDown("d"))
        {
            heroine.Transition(new running(1));
        }
    }
}