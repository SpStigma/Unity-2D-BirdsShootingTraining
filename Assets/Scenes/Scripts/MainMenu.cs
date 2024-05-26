using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Toggle main1;
    public Toggle main2;
    public Toggle main3;
    public Toggle main4;
    public void PlayGame()
    {
        if (main1.isOn)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
        else if (main2.isOn)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
        else if(main3.isOn)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
        else if(main4.isOn)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    public void QuitGame()
    {
        Debug.Log("quit succed");
        Application.Quit();
    }
}
