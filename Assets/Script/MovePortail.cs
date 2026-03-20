using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePortail : MonoBehaviour
{
    public float speed = 5f; // Vitesse du déplacement

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
