using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C_Sharp3_Button : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab
    public Transform spawnLocation; // Reference to the spawn location

    void SpawnCube()
    {
        // Instantiate a cube at the specified spawn location
        GameObject cube = Instantiate(cubePrefab, spawnLocation.position, Quaternion.identity);

        // Optionally, add a Rigidbody component to the instantiated cube
        Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();
        if (cubeRigidbody == null)
        {
            cube.AddComponent<Rigidbody>();
        }
    }
}
