using UnityEngine;

public class VenusController : Planet
{
    // Use this for initialization
    void Start()
    {
        radius = 21.69f;
        speed = 1.18f;
        target_tag = 2;
        header = "Venus";
        info = "Mass: 4.87 * 10^24 kg\nDiameter: 12104 km\nGravity: 8.9 m/s^2\nDistance from Sun: 108.2 * 10^6 km";
        transformPoint = new Vector3(0f, 0.7f, -2.8f);
    }
}
