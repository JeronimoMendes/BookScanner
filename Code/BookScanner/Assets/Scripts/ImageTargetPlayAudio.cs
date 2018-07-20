using UnityEngine;
using System.Collections;
using Vuforia;


public class ImageTargetPlayAudio : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;
    public AudioSource sound;
    public AudioClip clip;

    void Start()
    {
        sound.clip = clip;
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
        gameObject.SetActive(true);

        Debug.Log("Criei ITPA");
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {

        Debug.Log("OnTrackableStateChanged running");

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play audio when target is found
            Debug.Log("OnTrackableStateChanged Status: " + newStatus);

            sound.Play();
            Debug.Log("A tocar");
        }
        else
        {
            // Stop audio when target is lost
           sound.Stop();

        }
    }
}