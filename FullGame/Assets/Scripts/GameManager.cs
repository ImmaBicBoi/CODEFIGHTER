using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameEnded = false;
    public static int WaveMax = 10;
	// Update is called once per frame
	void Update () {
		if (gameEnded)
			return;

        if (PlayerStats.Lives <= 0)
        {
            EndGameLose();
            
        }

        if (WaveSpawner.waveCounter >= WaveMax)
        {
            EndGameWin();
        }

    }

    void EndGameLose()
    {
        gameEnded = true;
        Debug.Log("Game Over!");

        //Destroy(this.gameObject); // Added to end game
    }
    void EndGameWin()
    {
        gameEnded = true;
        Debug.Log("Level Cleared!");

        //Destroy(this.gameObject); // Added to end game
    }


}
