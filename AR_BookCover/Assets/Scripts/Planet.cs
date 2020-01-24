using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public Vector3 transformPoint;
    protected float radius;
    protected float speed;
    protected string defaultHeader = "Solar System";
    protected string defaultInfo = "Mercury\nVenus\nEarth\nMars";
    public int target_tag;
    public string header;
    protected string info;
    protected Vector3 GetPosition(float angle)
    {
        return new Vector3(radius * Mathf.Sin(angle), 0, radius * Mathf.Cos(angle));
    }

    protected virtual void Update()
    {
        // Arbitrary number to slow down orbital velocity. 
        this.transform.localPosition = GetPosition(Time.time * speed / 7);
    }
    protected virtual void OnMouseDown()
    {
        ZoomTarget.target_tag = ZoomTarget.zoom ? 0 : target_tag;
        TimeScale.header = ZoomTarget.zoom ? defaultHeader : header;
        TimeScale.info = ZoomTarget.zoom ? defaultInfo : info;
        ZoomTarget.zoom = !ZoomTarget.zoom;
    }
}