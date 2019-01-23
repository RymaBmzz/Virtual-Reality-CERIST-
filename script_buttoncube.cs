using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class script_buttoncube : MonoBehaviour, IVirtualButtonEventHandler {
    public GameObject vbbutton;
    public Animator cubeanim;
    public Animator brainanim;
    public GameObject brain;
    // Use this for initialization
    void Start () {
        vbbutton = GameObject.Find("cubebutt");
        vbbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeanim.GetComponent<Animator>();
        brainanim.GetComponent<Animator>();
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeanim.Play("cube_animation");
        brainanim.Play("brain_anim");
        Debug.Log("Button Pressed  !");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeanim.Play("none");
        brainanim.Play("none");
        Debug.Log("Button Released  !");
    }


}
