using JetBrains.Annotations;
using UnityEngine;

public static class GlobalVariables
{
    public static float score = 0;
}

public class BirdsBehaviour : MonoBehaviour
{
    public GameObject deathEffect;
    public float speedBegining;
    public float speedEnding;
    public float pointsBirds = 5;
    private float speed;
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

        speed = Random.Range(speedBegining, speedEnding);
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
        if (GameManagement.instance.isMenuActive == false)
        {
            FindObjectOfType<AudioManager>().Play("Shot");
            Destroy(gameObject);
            GameObject newDeathEffect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            GlobalVariables.score += pointsBirds;
            ManagerScore.instance.SetScore(GlobalVariables.score);
        }
    }
}
