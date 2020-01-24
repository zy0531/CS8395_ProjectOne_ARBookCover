using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBBehaviourBack : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject VBButtonObject;
    private GameObject SceneModels;
    // Start is called before the first frame update
    void Start()
    {
        VBButtonObject = GameObject.Find("VirtualButtonBack");
        VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        SceneModels = GameObject.Find("SceneModels");
        SceneModels.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("BUTTON Pressed");
        SceneModels.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("BUTTON RELEASED");
        SceneModels.SetActive(false);
    }
}
