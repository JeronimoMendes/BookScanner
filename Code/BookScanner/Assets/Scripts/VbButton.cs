using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbButton : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject Ytbtt;

    // Use this for initialization
    void Start()
    {
        Ytbtt = GameObject.Find("Ytbtt");
        Ytbtt.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour ytbtt)
    {
        if (ytbtt.VirtualButtonName == "Ytbtt")
        {
            Application.OpenURL("https://www.youtube.com/watch?v=XlWpupgrTCQ");
            Debug.Log("Button pressed");
        }
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour ytbtt)
    {
        if (ytbtt.VirtualButtonName == "Ytbtt")
        {
            Debug.Log("Button released");
        }
    }
}
