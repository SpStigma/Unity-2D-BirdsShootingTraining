using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        timer = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            UpdateTimer();
        }
    }

    void UpdateTimer()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        float milliseconds = Mathf.FloorToInt((timer - Mathf.Floor(timer)) * 100f);;

        if (timer < 0)
        {
            minutes = 0;
            seconds = 0;
            milliseconds = 0;
        }

        if (timer > 1)
        {
            timerText.text = $"{minutes:00}:{seconds:00}";
        }
        else
        {
            timerText.text = $"{minutes:00}:{seconds:00}:{milliseconds:00}";
        }
    }
}
