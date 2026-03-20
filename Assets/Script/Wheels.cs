using UnityEngine;

public class Wheels : MonoBehaviour
{
    public GameObject explosionEffect;

    public GameObject parent;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            this.parent.GetComponent<Characteristiques>().modifyPv(-other.gameObject.GetComponent<Bullet>().bulletPower);
            this.parent.GetComponent<UIHealphNumber>().showPv(this.parent.GetComponent<Characteristiques>().pv);
            GameObject go = Instantiate(explosionEffect, other.gameObject.transform.position, Quaternion.identity);
            go.transform.position += new Vector3(0.8f, 0, 0);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
