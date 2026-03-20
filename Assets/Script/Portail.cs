using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Portail : MonoBehaviour
{
    public int number = 0;

    public GameObject numberHolder;

    public GameObject impactPortail;

    private GameObject playersParent;

    private bool invulnerable = false;

    private float deltatimeInvulnerable = 0f;

    // Start is called before the first frame update
    void Start()
    {
        this.number = this.number == 0 ? Random.Range(0,3) : this.number;
        this.numberHolder.GetComponent<TextMeshProUGUI>().SetText((this.number >= 0 ? "+" : "") + this.number.ToString());
        this.playersParent = GameObject.FindGameObjectWithTag("PlayerParent");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.invulnerable)
        {
            this.deltatimeInvulnerable += Time.deltaTime;
            if (this.deltatimeInvulnerable >= 0.5f)
            {
                this.deltatimeInvulnerable = 0f;
                this.invulnerable = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            if (!this.invulnerable)
            {
                this.number += 1;
                this.invulnerable = true;
                this.numberHolder.GetComponent<TextMeshProUGUI>().SetText((this.number >= 0 ? "+" : "") + this.number.ToString());
            }
            GameObject impact = Instantiate(this.impactPortail, other.gameObject.transform.position, Quaternion.identity);
            impact.transform.position += new Vector3(0.5f, 0, 0);
            impact.transform.localScale *= 0.5f;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < this.number; i++)
            {
                GameObject player = Instantiate(playersParent.GetComponent<ActualGameObject>().actualGameObject, playersParent.transform);
                player.transform.position = GetPosition(playersParent.transform.childCount - 1, 0.2f, playersParent.transform.position);
            }

            Destroy(this.gameObject);
        }
    }

    public static Vector3 GetPosition(int index, float objectRadius, Vector3 center)
    {
        if (index == 0)
            return center; // premier au centre

        int ring = 1;
        int countSoFar = 1; // déjà mis l’objet central
        while (true)
        {
            float R = ring * 2f * objectRadius; // distance du centre (rayon du cercle)
            int capacity = Mathf.FloorToInt(Mathf.PI * R / objectRadius); // combien sur ce cercle

            if (index < countSoFar + capacity)
            {
                // Trouver la position de l'objet sur ce cercle
                int k = index - countSoFar; 
                float angle = 2f * Mathf.PI * k / capacity;
                float x = center.x + R * Mathf.Cos(angle);
                float z = center.z + R * Mathf.Sin(angle);
                return new Vector3(x, center.y, z);
            }

            countSoFar += capacity;
            ring++;
        }
    }
}
