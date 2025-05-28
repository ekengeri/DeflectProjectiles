using System.Collections;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    public float timeBetweenSheep = 3.0f;
    public GameObject sheepObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnSheep", 0f, timeBetweenSheep);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSheep()
    {
        Instantiate(sheepObject);
    }
}
