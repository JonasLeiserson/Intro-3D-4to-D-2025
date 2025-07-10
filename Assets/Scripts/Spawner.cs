using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    float tiempoEntreSpawns = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPincho", 13f, tiempoEntreSpawns);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnPincho()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}

    