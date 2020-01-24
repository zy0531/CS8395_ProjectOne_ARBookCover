using UnityEngine;
public class MercuryController : Planet
{
    void Start()
    {
        radius = 11.6f;
        speed = 1.59f;
        header = "Mercury";
        info = "Mass: 0.33 * 10^24 kg\nDiameter: 4879 km\nGravity: 3.7 m/s^2\nDistance from Sun: 57.9 * 10^6 km";
        target_tag = 1;
        transformPoint = new Vector3(0f, 0.6f, -3f);
    }
}
