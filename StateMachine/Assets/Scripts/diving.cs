using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diving : state
{
    private float startTime;

    public void entry(Heroine heroine)
    {
        heroine.GetComponent<Transform>().localScale = new Vector3(0.75f, 1.5f, 0.75f);
        heroine.GetComponent<Rigidbody>().AddForce(new Vector3(0, -20, 0), ForceMode.Impulse);
        startTime = Time.time;
    }
    public void exit(Heroine heroine)
    {
        heroine.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
    }
    public void Update(Heroine heroine)
    {
        if (Time.time - startTime > 0.1)
        {
            heroine.Transition(new standing());
        }

        if (Physics.Raycast(heroine.GetComponent<Transform>().position, Vector3.down, 0.1f))
        {
            heroine.Transition(new standing());
        }
    }
}
