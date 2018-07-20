using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbButtonSpotify : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject Spotifybtt;

    // Use this for initialization
    void Start()
    {
        Spotifybtt = GameObject.Find("Spotifybtt");
        Spotifybtt.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour spotifybtt)
    {
        if (spotifybtt.VirtualButtonName == "Spotifybtt")
        {
            Application.OpenURL("https://open.spotify.com/user/21rtvxg4wqj7kmumhzn7brn2a/playlist/4oAQbYsceNoNL4S37yWdmp?si=1f-uXGxnRIO59A6azLb3XA");
            Debug.Log("Button pressed");
        }
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour spotifybtt)
    {
        if (spotifybtt.VirtualButtonName == "Spotifybtt")
        {
            Debug.Log("Button released");
        }
    }
}