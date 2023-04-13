using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;
    public float timeBetweenSpawns = 1f;
    public float timeToSpawn = 2f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            SpawnPin();
        }
    }

    void SpawnPin() {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
