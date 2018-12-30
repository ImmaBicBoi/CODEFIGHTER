using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject ui;
    private bool gameEnded = false;


    void Update()
    {
        if (gameEnded)
        {
            return;
        }

        if (PlayerStats.Lives <= 0)
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        gameEnded = true;

        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }

    }

    public void Menu()
    {
        Debug.Log("Go to menu.");
        // put your scene transistion here
    }


}
