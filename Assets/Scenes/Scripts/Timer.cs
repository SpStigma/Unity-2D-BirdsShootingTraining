using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        UpdateTimer();
    }

    void UpdateTimer()
    {
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
    }
}
