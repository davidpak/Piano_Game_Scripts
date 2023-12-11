using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Sharp_3_Block_Script : MonoBehaviour
{
    private List<string> noteTags = new List<string>();

    void Start()
    {
        InitializeNoteTags();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object's tag is in the list
        if (noteTags.Contains(collision.gameObject.tag))
        {
            // Invoke the DeactivateObject method after 1 second
            Invoke("DeactivateObject", 1.0f);
        }
    }

    // Method to deactivate the game object
    void DeactivateObject()
    {
        // Set this game object as inactive
        gameObject.SetActive(false);
    }

    void InitializeNoteTags()
    {
        // Add musical notes to the list
        noteTags.Add("C3");
        noteTags.Add("C#3");
        noteTags.Add("D3");
        noteTags.Add("D#3");
        noteTags.Add("E3");
        noteTags.Add("F3");
        noteTags.Add("F#3");
        noteTags.Add("G3");
        noteTags.Add("G#3");
        noteTags.Add("A3");
        noteTags.Add("A#3");
        noteTags.Add("B3");
        noteTags.Add("C4");
        noteTags.Add("C#4");
        noteTags.Add("D4");
        noteTags.Add("D#4");
        noteTags.Add("E4");
        noteTags.Add("F4");
        noteTags.Add("F#4");
        noteTags.Add("G4");
        noteTags.Add("G#4");
        noteTags.Add("A4");
        noteTags.Add("A#4");
        noteTags.Add("B4");
        noteTags.Add("C5");
        noteTags.Add("C#5");
        noteTags.Add("D5");
        noteTags.Add("D#5");
        noteTags.Add("E5");
        noteTags.Add("F5");
        // Add more notes as needed...
    }

}
