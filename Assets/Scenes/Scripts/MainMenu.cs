using System.Collections;
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
    public Toggle cursorSwap;
    public Texture2D cursor1;
    public Texture2D cursor2;
    

    public void Start()
    {
        InitializeCursor();
    }

    public void PlayGame()
    {
        if (main1.isOn)
        {
            PlayButtonSFX();
            StartCoroutine(BackgroundLoader(2));
        }
        else if (main2.isOn)
        {
            PlayButtonSFX();
            StartCoroutine(BackgroundLoader(3));
        }
        else if(main3.isOn)
        {
            PlayButtonSFX();
            StartCoroutine(BackgroundLoader(4));
        }
        else if(main4.isOn)
        {
            PlayButtonSFX();
            StartCoroutine(BackgroundLoader(5));
        }
        else
        {
            PlayButtonSFX();
            StartCoroutine(BackgroundLoader(1));
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

    public void PlayButtonSFX()
    {
        FindObjectOfType<AudioManager>().Play("Button");
    }

    IEnumerator BackgroundLoader(int numScene)
    {
        yield return new WaitForSeconds(.25f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + numScene);

    }

    public void ChoseCursor()
    {
        Vector2 hotSpot;
        if(cursorSwap.isOn)
        {
            hotSpot = new Vector2(cursor2.width / 2, cursor2.height / 2);
            Cursor.SetCursor(cursor2, hotSpot, CursorMode.Auto);
        }
    }

    private void InitializeCursor()
    {
        Vector2 hotSpot = new Vector2(cursor1.width / 2, cursor1.height / 2);
        Cursor.SetCursor(cursor1, hotSpot, CursorMode.Auto);
    }
}
