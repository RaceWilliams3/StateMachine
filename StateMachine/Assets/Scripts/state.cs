using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface state
{
    void entry(Heroine heroine);
    void exit(Heroine heroine);
    void Update(Heroine heroine);
}
