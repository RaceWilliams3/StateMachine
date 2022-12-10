using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ducking : state
{
    public void entry(Heroine heroine)
    {
        heroine.GetComponent<Transform>().localScale = new Vector3(1.1f, 0.5f, 1.1f);
    }
    public void exit(Heroine heroine)
    {
        heroine.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
    }
    public void Update(Heroine heroine)
    {
        if (Input.GetKeyUp("s"))
        {
            heroine.Transition(new standing());
        }
    }
}
