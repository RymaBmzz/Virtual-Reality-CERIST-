using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class call_brain : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbbutton;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed ! Brain Scene On !!!");
        SceneManager.LoadScene("cerveau_tournant");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released ! Brain Scene Off !!!");
       // SceneManager.LoadScene("brain_caller");
    }

    // Use this for initialization
    void Start () {
        vbbutton = GameObject.Find("brain_butt");
        vbbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
	
}
