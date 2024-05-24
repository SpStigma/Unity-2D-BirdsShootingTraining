using UnityEngine;
using TMPro;

public class ManagerScore : MonoBehaviour
{
    public static ManagerScore instance;
    public TextMeshProUGUI scoreText;


    private void Awake()
    {
        instance = this;
    }

    public void SetScore(float Score)
    {
        scoreText.text = "Score: " + GlobalVariables.score;
    }
}
