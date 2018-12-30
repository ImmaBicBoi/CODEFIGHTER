using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCleared : MonoBehaviour
{

    public GameObject ui;
    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded)
        {
            return;
        }

        if (WaveSpawner.waveCounter >= 11)
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

    public void Win()
    {

        //put transition here
    }


}
