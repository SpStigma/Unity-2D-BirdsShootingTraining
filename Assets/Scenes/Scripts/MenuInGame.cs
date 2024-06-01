using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInGame : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("Menu");
        GlobalVariables.score = 0;
        Time.timeScale = 1;
    }
}
