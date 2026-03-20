using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateDestroy : MonoBehaviour
{
    public float lifeSecond;

    private float deltatime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.deltatime += Time.deltaTime;
        if (this.deltatime >= this.lifeSecond)
        {
            Destroy(this.gameObject);
        }
    }
}
