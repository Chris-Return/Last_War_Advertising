using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardZ : MonoBehaviour
{
    public float speed = 5f; // Vitesse du déplacement

    public bool directionPlayer = true;

    void Update()
    {
        // Déplacement automatique sur l'axe +X
        transform.Translate(this.directionPlayer ? Vector3.left * speed * Time.deltaTime : Vector3.right * speed * Time.deltaTime);
    }
}
