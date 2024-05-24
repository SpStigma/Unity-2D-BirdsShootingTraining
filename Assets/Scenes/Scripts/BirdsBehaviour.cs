using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BirdsBehaviour : MonoBehaviour
{
    public GameObject deathEffect;
    public float speed = 5f;
    private Vector3 direction;

    void Start()
    {
        // Déterminer la direction en fonction de la position initiale
        if (transform.position.x > Camera.main.transform.position.x)
        {
            // L'oiseau est à droite de la caméra, il doit aller à gauche
            direction = Vector3.left;
        }
        else
        {
            // L'oiseau est à gauche de la caméra, il doit aller à droite
            direction = Vector3.right;
        }
    }

    void Update()
    {
        // Faire avancer l'oiseau
        transform.Translate(direction * speed * Time.deltaTime);

        if(transform.position.x > 5 || transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        GameObject newDeathEffect = Instantiate(deathEffect, transform.position, Quaternion.identity);
    }
}
