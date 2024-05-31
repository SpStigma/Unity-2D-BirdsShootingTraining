using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public GameObject menuOption;
    private bool isMenuActive = false;
    public float EndGameTime = 60f;
    private float time;
    public GameObject deathEffect;
    public GameObject panel;

    void Start()
    {
        time = 0f;
        Time.timeScale = 1f;
    }

    void Update()
    {
        time += Time.deltaTime;

        if (time >= EndGameTime)
        {
            EndGame();
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                if (!isMenuActive)
                {
                    Time.timeScale = 0f;
                    menuOption.SetActive(true);
                    isMenuActive = true;
                }
                else
                {
                    Time.timeScale = 1f;
                    menuOption.SetActive(false);
                    isMenuActive = false;
                }
            }
        }

    }

    void EndGame()
    {
        PausedGame();
        DestroyAllBirds();
        SetActivePanel(panel);
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
