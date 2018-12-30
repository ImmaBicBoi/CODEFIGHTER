using UnityEngine;
using UnityEngine.SceneManagement;


public class menuscript : MonoBehaviour {

    public enum MenuStates { Main,LS,Login};
    public MenuStates currentState;

    //menu panel objects
    public GameObject mainMenu;
    public GameObject LSMenu;


	// Use this for initialization
	public void OnPlay () {
        Debug.Log("Play btn Pressed.");
        SceneManager.LoadScene("UIStaging");
	}
    public void OnLogin()
    {
        Debug.Log("Login btn Pressed.");
        SceneManager.LoadScene("LoginRedone");
    }

    public void OnLvl1()
    {
        Debug.Log("lvl1 btn Pressed.");
        WaveSpawner.waveCounter = 0;
        WaveSpawner.waveIndex = 0;
        PlayerStats.Lives = PlayerStats.startLives;
        PlayerStats.Money = PlayerStats.startMoney;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void OnLvl2()
    {
        Debug.Log("lvl2 btn Pressed.");
        WaveSpawner.waveCounter = 0;
        WaveSpawner.waveIndex = 0;
        PlayerStats.Lives = PlayerStats.startLives;
        PlayerStats.Money = PlayerStats.startMoney;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
    }
    public void OnLvl3()
    {
        Debug.Log("lvl3 btn Pressed.");
        WaveSpawner.waveCounter = 0;
        WaveSpawner.waveIndex = 0;
        PlayerStats.Lives = PlayerStats.startLives;
        PlayerStats.Money = PlayerStats.startMoney;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level3");
    }
    public void OnMain()
    {
        Debug.Log("Main back btn Pressed.");
        SceneManager.LoadScene("MainMenu");
    }

    public void OnIntro()
    {
        Debug.Log("Main back btn Pressed.");
        SceneManager.LoadScene("The Intro");

    }
    public void OnIntro2()
    {
        Debug.Log("Main back btn Pressed.");
        SceneManager.LoadScene("Instructions_Pg_1");

    }
    public void OnIntro3()
    {
        Debug.Log("Main back btn Pressed.");
        SceneManager.LoadScene("Instructions_Pg_2");

    }
    public void OnIntro4()
    {
        Debug.Log("Main back btn Pressed.");
        SceneManager.LoadScene("Instructions_Pg_3");

    }
    public void OnIntro5()
    {
        Debug.Log("Main back btn Pressed.");
        SceneManager.LoadScene("Instructions_Pg_4");

    }

    // Update is called once per frame
    void Update () {
	
	}
}
