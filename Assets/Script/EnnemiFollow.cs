using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemiFollow : MonoBehaviour
{
    public Transform target;      // Objet à suivre
    public float speed = 1f;      // Vitesse du suivi

    void Update()
    {
        if (target != null)
        {
            // Interpolation linéaire pour un mouvement plus fluide
            transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
