using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G4Script : MonoBehaviour
{
    // Determine which key has been pressed
    public AudioClip pianoClips;
    public AudioSource audioSource;
    public Transform key;

    public float pressHeight = 0.29f;

    bool pressing = false;



    void Update()
    {
        if (key.localPosition.y < pressHeight)
        {
            OnKeyPush();
        }
        else
        {
            OnKeyRelease();
        }
    }

    void OnKeyPush()
    {
        if (!pressing)
        {
            pressing = true;
            // Play the note corresponding to the tag
            audioSource.PlayOneShot(pianoClips);
        }
    }

    void OnKeyRelease()
    {
        if (pressing)
        { 
            pressing = false;
            audioSource.Stop();
        }
    }
}

