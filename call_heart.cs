using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class call_heart : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbbutton;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed ! Heart Scene On !!!");
        SceneManager.LoadScene("heart_scene");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released ! Heart Scene Off !!!");
        // SceneManager.LoadScene("brain_caller");
    }

    // Use this for initialization
    void Start()
    {
        vbbutton = GameObject.Find("heart_butt");
        vbbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }


}
