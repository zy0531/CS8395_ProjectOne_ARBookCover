using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EarthSystemController : Planet
{

    public float selfSpeed = 12.0f;

    private Transform Earth;

    // Use this for initialization
    void Start()
    {
        transformPoint = new Vector3(0f, 1f, -5f);
        radius = 34.0f;
        speed = 1f;
        target_tag = 3;
        header = "Earth";
        info = "Mass: 5.97 * 10^24 kg\nDiameter: 12756 km\nGravity: 9.8 m/s^2\nDistance from Sun: 149.6  * 10^6 km\n\nMoon:\nMass: 0.073 * 10^24 kg\nDiameter: 3475 km\nGravity: 1.6 m/s^2\nDistance from Sun: 0.384 * 10^6 km";
        Earth = this.transform.Find("EarthPlanet");
    }

    // Update is called once per frame
    protected override void Update()
    {
        Earth.Rotate(Vector3.up, Time.deltaTime * selfSpeed);
        base.Update();
    }
}
