using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonscript : MonoBehaviour, IVirtualButtonEventHandler {
    private GameObject vbButtonObject;
    private GameObject zombie;
    // Use this for initialization
    void Start()
    {
        vbButtonObject = GameObject.Find("ButtonOn");
        zombie = GameObject.Find("zombie");
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button activé !!!");
       zombie.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       zombie.GetComponent<Animation>().Stop();
    }
   
}
