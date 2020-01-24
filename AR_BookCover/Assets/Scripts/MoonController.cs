using UnityEngine;
using System.Collections;

public class MoonController : Planet
{
    void Start()
    {
        radius = 3.0f;
        speed = 0.0343f;
        header = "Moon";
        target_tag = 5;
        transformPoint = new Vector3(0f, 1f, -5f);
    }
}
