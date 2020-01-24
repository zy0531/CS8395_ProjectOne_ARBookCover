using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthClick : MonoBehaviour
{
    public float speed = 12.0f;
    void Update()
    {
        this.transform.Rotate(Vector3.up, Time.deltaTime * speed);
    }

}
