using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomTarget : MonoBehaviour
{
    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    public static bool zoom = false;
    public static int target_tag = 0;
    public float turnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis
    public float panSpeed = 4.0f;       // Speed of the camera when being panned
    public float zoomSpeed = 4.0f;      // Speed of the camera going back and forth
    private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
    private bool isRotating;    // Is the camera being rotated?
    private bool isZooming;     // Is the camera zooming?
    public Planet[] planets;
    private int currentMusic;

    void Play()
    {
        foreach (Planet p in planets)
        {
            GameObject obj = GameObject.Find(p.header);
            AudioSource music = obj.GetComponent<AudioSource>();
            if (target_tag != p.target_tag) music.Stop();
            else
            {
                music.Play();
                currentMusic = p.target_tag;
            }

        }
    }

    void Update()
    {
        // Left mouse button
        if (Input.GetMouseButtonDown(0))
        {
            // Get mouse origin
            mouseOrigin = Input.mousePosition;
            isRotating = true;
        }

        // Get the middle mouse button
        if (Input.GetMouseButtonDown(1))
        {
            // Get mouse origin
            mouseOrigin = Input.mousePosition;
            isZooming = true;
        }

        // Disable movements on button release
        if (!Input.GetMouseButton(0)) isRotating = false;
        if (!Input.GetMouseButton(1)) isZooming = false;

        // Rotate camera along X and Y axis
        if (isRotating)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

            transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
        }

        // Move the camera linearly along Z axis
        if (isZooming)
        {
            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
            Vector3 move = pos.y * zoomSpeed * transform.forward;
            transform.Translate(move, Space.World);
        }

        if (Input.GetMouseButton(0))
        {

            if (zoom)
            {
                zoom = false;
                return;
            }
            else
            {
                zoom = true;
                return;
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (zoom)
            {
                zoom = false;
                target_tag = 0;
            }
        }


        if (target_tag != currentMusic && target_tag > 0) Play();

        if (target_tag == 0)
        {
            target = GameObject.Find("Sun").transform;
            Vector3 targetPosition = target.TransformPoint(new Vector3(0f, 1f, -5f));
            this.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
        else
        {
            foreach (Planet p in planets)
            {
                if (p.target_tag == target_tag)
                {
                    target = GameObject.Find(p.header).transform;
                    Vector3 targetPosition = target.TransformPoint(p.transformPoint);
                    this.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
                }
            }
        }
    }
}
