using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiSpawner : MonoBehaviour
{
    public GameObject littleEnnemi;

    public GameObject giantEnnemi;

    public GameObject leftLimit;

    public GameObject rightLimit;

    private float deltatime;

    private float deltatimeGiant;

    public float timeBetweenEachSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        deltatime += Time.fixedDeltaTime;
        this.deltatimeGiant += Time.fixedDeltaTime;

        if (deltatime >= timeBetweenEachSpawn)
        {
            deltatime = 0f;
            Instantiate(littleEnnemi, new Vector3(transform.position.x, transform.position.y, Random.Range(leftLimit.transform.position.z, rightLimit.transform.position.z)), Quaternion.identity);
        }

        if (this.deltatimeGiant >= 5f)
        {
            this.deltatimeGiant = 0f;
            GameObject go = Instantiate(giantEnnemi, transform.position, Quaternion.identity);
            go.transform.position += new Vector3(0, -transform.position.y, 0);
        }
    }
}
