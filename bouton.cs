using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class bouton : MonoBehaviour , IVirtualButtonEventHandler
{
     public GameObject vbbutton;
 public void OnButtonPressed(VirtualButtonBehaviour vb)
     {
         Debug.Log("Button Pressed  !");
     }

     public void OnButtonReleased(VirtualButtonBehaviour vb)
     {
         Debug.Log("Button Released  !");
     }

     // Use this for initialization
     void Start () {
     vbbutton = GameObject.Find("bouton");
     vbbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
 }
     
   /* public GameObject vbbutton;
    public GameObject brain;
    // public Animator animbrain;

    // Use this for initialization
    void Start()
    {
        vbbutton = GameObject.Find("bouton");
       // brain = Instantiate(Resources.Load("brain_rotate")) as GameObject; 
       GameObject.Find("brain_rotate");
        vbbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        // animbrain.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        // animbrain.Play("brain_anim");
        Debug.Log("Button Pressed  !");
        brain.GetComponent<Animation>().Play();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        // animbrain.Play("none");
        Debug.Log("Button Released  !");
        brain.GetComponent<Animation>().Stop();
    }

    */
}
