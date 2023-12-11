using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoPlayer : MonoBehaviour
{
    // Determine which key has been pressed

    public Transform key;

    public float pressHeight = -0.15f;

    bool pressing = false;

    public AudioSource C4_note;
    public AudioSource C_sharp4_note;
    public AudioSource D4_note;
    public AudioSource D_sharp4_note;
    public AudioSource E4_note;
    public AudioSource F4_note;
    public AudioSource F_sharp4_note;
    public AudioSource G4_note;
    public AudioSource G_sharp4_note;
    public AudioSource A4_note;
    public AudioSource A_sharp4_note;
    public AudioSource B4_note;
    public AudioSource C5_note;
    public AudioSource C_sharp5_note;
    public AudioSource D5_note;
    public AudioSource D_sharp5_note;
    public AudioSource E5_note;
    public AudioSource F5_note;

    void Start()
    {
        key = GetComponent<Transform>();
    }

    void Update()
    {
        OnKeyPush();
        // if (key.localPosition.y < pressHeight)
        // {
        //     OnKeyPush();
        // }
        // else
        // {
        //     OnKeyRelease();
        // }
    }

    void OnKeyPush()
    {
        // get the tag of the key that was pressed
        string keyTag = key.tag;
        if (!pressing)
        {
            pressing = true;
            // Play the note corresponding to the tag
            switch (keyTag)
            {
                case "C4":
                    Play_C4();
                    break;
                case "C_sharp4":
                    Play_C_sharp4();
                    break;
                case "D4":
                    Play_D4();
                    break;
                case "D_sharp4":
                    Play_D_sharp4();
                    break;
                case "E4":
                    Play_E4();
                    break;
                case "F4":
                    Play_F4();
                    break;
                case "F_sharp4":
                    Play_F_sharp4();
                    break;
                case "G4":
                    Play_G4();
                    break;
                case "G_sharp4":
                    Play_G_sharp4();
                    break;
                case "A4":
                    Play_A4();
                    break;
                case "A_sharp4":
                    Play_A_sharp4();
                    break;
                case "B4":
                    Play_B4();
                    break;
                case "C5":
                    Play_C5();
                    break;
                case "C_sharp5":
                    Play_C_sharp5();
                    break;
                case "D5":
                    Play_D5();
                    break;
                case "D_sharp5":
                    Play_D_sharp5();
                    break;
                case "E5":
                    Play_E5();
                    break;
                case "F5":
                    Play_F5();
                    break;
                default:
                    break;
            }
        }
    }

    void OnKeyRelease()
    {
        if (pressing)
        { 
            // Stop whatever note is being playing
            string keyTag = key.tag;
            switch (keyTag)
            {
                case "C4":
                    C4_note.Stop();
                    break;
                case "C_sharp4":
                    C_sharp4_note.Stop();
                    break;
                case "D4":
                    D4_note.Stop();
                    break;
                case "D_sharp4":
                    D_sharp4_note.Stop();
                    break;
                case "E4":
                    E4_note.Stop();
                    break;
                case "F4":
                    F4_note.Stop();
                    break;
                case "F_sharp4":
                    F_sharp4_note.Stop();
                    break;
                case "G4":
                    G4_note.Stop();
                    break;
                case "G_sharp4":
                    G_sharp4_note.Stop();
                    break;
                case "A4":
                    A4_note.Stop();
                    break;
                case "A_sharp4":
                    A_sharp4_note.Stop();
                    break;
                case "B4":
                    B4_note.Stop();
                    break;
                case "C5":
                    C5_note.Stop();
                    break;
                case "C_sharp5":
                    C_sharp5_note.Stop();
                    break;
                case "D5":
                    D5_note.Stop();
                    break;
                case "D_sharp5":
                    D_sharp5_note.Stop();
                    break;
                case "E5":
                    E5_note.Stop();
                    break;
                case "F5":
                    F5_note.Stop();
                    break;
                default:
                    break;
            }
            pressing = false;
        }
    }

    public void Play_C4()
    {
        C4_note.Play();
    }

    public void Play_C_sharp4()
    {
        C_sharp4_note.Play();
    }

    public void Play_D4()
    {
        D4_note.Play();
    }

    public void Play_D_sharp4()
    {
        D_sharp4_note.Play();
    }

    public void Play_E4()
    {
        E4_note.Play();
    }

    public void Play_F4()
    {
        F4_note.Play();
    }

    public void Play_F_sharp4()
    {
        F_sharp4_note.Play();
    }

    public void Play_G4()
    {
        G4_note.Play();
    }

    public void Play_G_sharp4()
    {
        G_sharp4_note.Play();
    }

    public void Play_A4()
    {
        A4_note.Play();
    }

    public void Play_A_sharp4()
    {
        A_sharp4_note.Play();
    }

    public void Play_B4()
    {
        B4_note.Play();
    }

    public void Play_C5()
    {
        C5_note.Play();
    }

    public void Play_C_sharp5()
    {
        C_sharp5_note.Play();
    }


    public void Play_D5()
    {
        D5_note.Play();
    }

    public void Play_D_sharp5()
    {
        D_sharp5_note.Play();
    }

    public void Play_E5()
    {
        E5_note.Play();
    }

    public void Play_F5()
    {
        F5_note.Play();
    }
}
