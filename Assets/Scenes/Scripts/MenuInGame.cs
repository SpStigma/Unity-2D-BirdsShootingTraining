using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInGame : MonoBehaviour
{
    public void GoHome()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
