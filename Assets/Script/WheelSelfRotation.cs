using UnityEngine;

public class WheelSelfRotation : MonoBehaviour
{
    private float speed = -45f; 
    // vitesse en degrés par seconde (modifiable dans l’inspecteur)

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
