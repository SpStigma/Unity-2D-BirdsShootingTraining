using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public GameObject menuOption;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            menuOption.SetActive(true);
        }
    }
}
