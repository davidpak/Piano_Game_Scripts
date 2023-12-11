using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPianoController : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab
    public AudioSource audioSource; // Reference to the audio source
    public AudioSource wolfInterval;
    private float spawnCooldown = 0.0002f; // Cooldown time in seconds
    private bool canSpawn = true; // Flag to check if spawning is allowed

    // Dictionary to map musical notes to positions
    private Dictionary<string, Vector3> notePositions = new Dictionary<string, Vector3>();
    private List<string> chordTags = new List<string>();

    void Start()
    {
        InitializeNotePositions();
    }

    void Update()
    {
        // Check if the cooldown has elapsed and set canSpawn to true
        if (!canSpawn)
        {
            spawnCooldown -= Time.deltaTime;

            if (spawnCooldown <= 0)
            {
                canSpawn = true;
                spawnCooldown = 0.0002f; // Reset cooldown time
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        string noteTag = other.gameObject.tag;

        if (canSpawn && notePositions.ContainsKey(noteTag))
        {
            Debug.Log("Spawned cube at " + notePositions[noteTag]);
            SpawnCube(noteTag);
            canSpawn = false; // Set canSpawn to false to start the cooldown
        } else if (canSpawn && chordTags.Contains(noteTag))
        {
            SpawnChord(noteTag);
            canSpawn = false; // Set canSpawn to false to start the cooldown
        } else if (noteTag == "Wolf") {
            wolfInterval.Play();
        }
    }

    void SpawnCube(string noteTag)
    {
        // Instantiate a cube at the specified spawn location
        GameObject cube = Instantiate(cubePrefab, notePositions[noteTag], Quaternion.identity);
    }

    void SpawnChord(string noteTag)
    {
        switch (noteTag) {
            case "Amaj":
                SpawnCube("A3Button");
                SpawnCube("C#4Button");
                SpawnCube("E4Button");
                break;
            case "Octave":
                SpawnCube("A3Button");
                SpawnCube("A4Button");
                break;
            case "Perfect5th":
                SpawnCube("A3Button");
                SpawnCube("E4Button");
                break;
            case "Major3rd":
                SpawnCube("A3Button");
                SpawnCube("C#4Button");
                break;
        }
    }

    void InitializeNotePositions()
    {
        // Add musical notes and their corresponding positions
        notePositions["C3Button"] = new Vector3(-6.8f, 4.4f, 15.68f);
        notePositions["C#3Button"] = new Vector3(-5.83f, 4.4f, 18.68f);
        notePositions["D3Button"] = new Vector3(-5.1f, 4.4f, 15.68f);
        notePositions["D#3Button"] = new Vector3(-4.6f, 4.4f, 18.63f);
        notePositions["E3Button"] = new Vector3(-3.8f, 4.4f, 15.68f);
        notePositions["F3Button"] = new Vector3(-3f, 4.4f, 15.68f);
        notePositions["F#3Button"] = new Vector3(-2.4f, 4.4f, 18.63f);
        notePositions["G3Button"] = new Vector3(-1.6f, 4.4f, 15.68f);
        notePositions["G#3Button"] = new Vector3(-0.9f, 4.4f, 18.63f);
        notePositions["A3Button"] = new Vector3(-0.2f, 4.4f, 15.68f);
        notePositions["A#3Button"] = new Vector3(0.3f, 4.4f, 18.63f);
        notePositions["B3Button"] = new Vector3(1.1f, 4.4f, 15.68f);
        notePositions["C4Button"] = new Vector3(2.5f, 4.4f, 15.68f);
        notePositions["C#4Button"] = new Vector3(3.0f, 5.6f, 18.63f);
        notePositions["D4Button"] = new Vector3(3.5f, 4.4f, 15.68f);
        notePositions["D#4Button"] = new Vector3(4.2f, 5.66f, 18.63f);
        notePositions["E4Button"] = new Vector3(5.0f, 4.4f, 15.68f);
        notePositions["F4Button"] = new Vector3(6.12f, 4.4f, 15.68f);
        notePositions["F#4Button"] = new Vector3(6.8f, 4.4f, 18.63f);
        notePositions["G4Button"] = new Vector3(7.5f, 4.4f, 15.68f);
        notePositions["G#4Button"] = new Vector3(8.1f, 4.4f, 18.63f);
        notePositions["A4Button"] = new Vector3(8.9f, 4.4f, 15.68f);
        notePositions["A#4Button"] = new Vector3(9.5f, 4.4f, 18.63f);
        notePositions["B4Button"] = new Vector3(10.2f, 4.4f, 15.68f);
        notePositions["C5Button"] = new Vector3(11.1f, 4.4f, 15.68f);
        notePositions["C#5Button"] = new Vector3(11.8f, 4.4f, 18.63f);
        notePositions["D5Button"] = new Vector3(12.5f, 4.4f, 15.68f);
        notePositions["D#5Button"] = new Vector3(13.1f, 4.4f, 18.63f);
        notePositions["E5Button"] = new Vector3(13.8f, 4.4f, 15.68f);
        notePositions["F5Button"] = new Vector3(15.1f, 4.4f, 15.68f);

        // Add chords and their corresponding positions
        chordTags.Add("Amaj");
        chordTags.Add("Octave");
        chordTags.Add("Perfect5th");
        chordTags.Add("Major3rd");
        // Add more notes as needed...
    }
}
