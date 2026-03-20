using System.Collections.Generic;
using UnityEngine;

public class PortailSpawner : MonoBehaviour
{
    public List<GameObject> spawnable;

    private float deltatime = 0f;

    private float timeBetweenEachSpawn = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.deltatime += Time.deltaTime;
        if (this.deltatime > this.timeBetweenEachSpawn)
        {
            this.deltatime = 0f;
            Instantiate(spawnable[Random.Range(0, spawnable.Count)], this.transform);
        }
    }
}
