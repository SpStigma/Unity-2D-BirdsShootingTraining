using System.Data.Common;
using Unity.Mathematics;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public float EndGameTime = 60f;
    private float time;
    public GameObject deathEffect;
    public GameObject panel;

    void Start()
    {
        time = 0f;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= EndGameTime)
        {
            PausedGame();
            DestroyAllBirds();
            SetActivePanel(panel);
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    void PausedGame()
    {
        Time.timeScale = 0;
    }

    void DestroyAllBirds()
    {
        BirdsBehaviour[] birds = GameObject.FindObjectsOfType<BirdsBehaviour>();

        foreach (BirdsBehaviour bird in birds)
        {
            Vector3 birdPosition = bird.transform.position;
            Destroy(bird.gameObject);
            Instantiate(deathEffect, birdPosition, Quaternion.identity);
        }
    }

    void SetActivePanel(GameObject panel)
    {
        panel.SetActive(true);
    }
}
