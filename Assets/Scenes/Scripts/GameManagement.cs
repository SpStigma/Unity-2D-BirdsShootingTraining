using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public GameObject menuOption;
    private bool isMenuActive = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isMenuActive)
            {
                Time.timeScale = 0;
                menuOption.SetActive(true);
                isMenuActive = true;
            }
            else
            {
                Time.timeScale = 1;
                menuOption.SetActive(false);
                isMenuActive = false;
            }
        }
    }
}
