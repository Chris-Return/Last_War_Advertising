using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Deplacement : MonoBehaviour
{
    public float speed = 5f;       // Vitesse du déplacement
    public float deadZone = 100f;  // Zone neutre autour du personnage en pixels
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        // Position du personnage en coordonnées écran
        Vector3 playerScreenPos = cam.WorldToScreenPoint(transform.position);

        // Position de la souris
        Vector3 mousePos = Input.mousePosition;

        if (this.transform.position.z > -2 && this.transform.position.z < 4.7f)
        {
            // Calcul de l'écart horizontal entre la souris et le joueur
            float deltaX = mousePos.x - playerScreenPos.x;

            // Vérifie si la souris est en dehors de la zone neutre
            if (deltaX > deadZone)
            {
                // Souris à droite → déplacement vers l'avant (axe Z positif)
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            else if (deltaX < -deadZone)
            {
                // Souris à gauche → déplacement vers l'arrière (axe Z négatif)
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
            // Sinon, on ne fait rien → le perso reste immobile
        }

        if (this.transform.position.z <= -2)
        {
            this.transform.position += new Vector3(0, 0, 0.05f);
        }

        if (this.transform.position.z >= 4.7f)
        {
            this.transform.position += new Vector3(0, 0, -0.05f);
        }
    }
}
