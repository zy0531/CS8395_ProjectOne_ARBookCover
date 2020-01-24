using UnityEngine;

public class MarsController : Planet
{
    void Start()
    {
        radius = 5.72f;
        speed = 0.808f;
        target_tag = 4;
        header = "Mars";
        info = "Mass: 0.642 * 10^24 kg\nDiameter: 6792 km\nGravity: 3.7 m/s^2\nDistance from Sun: 227.9 * 10^6 km";
        transformPoint = new Vector3(0f, 0.7f, -4f);
    }
}
