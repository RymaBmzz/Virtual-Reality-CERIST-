using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class GoMain : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbbutton;
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Pressed ! Getting back to the home page !!!");
        SceneManager.LoadScene("brain_caller");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Released ! Home page Off !!!");
        // SceneManager.LoadScene("brain_caller");
    }

    // Use this for initialization
    void Start()
    {
        vbbutton = GameObject.Find("bouton");
        vbbutton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }


}
