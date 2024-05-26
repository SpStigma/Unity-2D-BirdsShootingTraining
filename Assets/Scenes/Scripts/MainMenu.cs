using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Toggle main1;
    public Toggle main2;
    public Toggle main3;
    public Toggle main4;
    public GameObject parallax1;
    public GameObject parallax2;
    public GameObject parallax3;
    public GameObject parallax4;
    public GameObject parallax5;
    
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

    public void ChooseBackground()
    {
        parallax1.SetActive(false);
        parallax2.SetActive(false);
        parallax3.SetActive(false);
        parallax4.SetActive(false);
        parallax5.SetActive(false);

        if (main1.isOn)
        {
            parallax2.SetActive(true);
        }
        else if (main2.isOn)
        {
            parallax5.SetActive(true);
        }
        else if (main3.isOn)
        {
            parallax4.SetActive(true);
        }
        else if (main4.isOn)
        {
            parallax3.SetActive(true);
        }
        else
        {
            parallax1.SetActive(true);
        }
    }
}
