using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiFollowAdder : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ennemi")
        {
            other.gameObject.AddComponent<EnnemiFollow>();
            other.gameObject.GetComponent<EnnemiFollow>().target = this.target.transform;
            Destroy(other.gameObject.GetComponent<MoveTowardZ>());
        }
    }
}
