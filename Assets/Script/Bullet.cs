using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject impactObject;
    public int bulletPower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ennemi")
        {
            Debug.Log("Ennemi detected");
            Characteristiques charact = other.gameObject.GetComponent<Characteristiques>();
            if (charact == null)
            {
                charact = other.gameObject.AddComponent<Characteristiques>();
                // Initialiser les PV à 3
                charact.pv = 3;
            }
 
            charact.modifyPv(-bulletPower);
            GameObject impact = Instantiate(impactObject, transform.position, Quaternion.identity);
            impact.transform.position += new Vector3(0.7f,0, 0);
            Destroy(this.gameObject);
        }
    }
}
