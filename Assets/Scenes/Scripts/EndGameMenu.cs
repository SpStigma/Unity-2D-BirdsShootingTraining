using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    public TextMeshProUGUI congratulations;

    void Start()
    {
        Congratulation();
    }
    
    // Method to Update the congratulation message.
    public void Congratulation()
    {
        congratulations.text = "Good Job\n Your score: " + GlobalVariables.score;
    }
    // Method to reload the current scene.
    public void ReloadTheScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
