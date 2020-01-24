using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBbehaviourFront : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject VBButtonObject;
    private GameObject Flower;
    private GameObject Butterfly;
    // Start is called before the first frame update
    void Start()
    {
        VBButtonObject = GameObject.Find("VirtualButtonFront");
        VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Flower = GameObject.Find("Petals Prefab 2");
        Butterfly = GameObject.Find("Butterfly");
        Flower.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("BUTTON Pressed");
        Flower.SetActive(true);
        Butterfly.SetActive(false);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("BUTTON RELEASED");
        Flower.SetActive(false);
        Butterfly.SetActive(true);
    }
}
