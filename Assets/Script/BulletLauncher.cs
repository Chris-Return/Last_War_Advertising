using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    public GameObject bullet;

    private float deltatime = 0f;

    public float launchDelay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.deltatime += Time.deltaTime;
        if (this.deltatime >= this.launchDelay)
        {
            this.deltatime = 0f;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
