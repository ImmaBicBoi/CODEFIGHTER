using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaveSpawner : MonoBehaviour {

	public Transform enemyPrefab;
    public Transform whiteBoxPrefab;
    public float monsterType;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	public Text waveCountdownText;

	public static int waveIndex = 0;
    public static int waveCounter = 0;
	void Update ()
	{
		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
		}

		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

		waveCountdownText.text = string.Format("{0:00.00}", countdown);
	}

	IEnumerator SpawnWave ()
	{
		waveIndex++;
        waveCounter++;
		for (int i = 0; i < waveIndex; i++)
		{
			SpawnEnemy();
			yield return new WaitForSeconds(0.5f);
		}
	}

	void SpawnEnemy ()
	{
        
        if (SceneManager.GetActiveScene().name == "Level1") {

            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
        } else { 
            monsterType = Random.Range(0.0f, 1.0f);
            if (monsterType <= .5f)
            {
                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
            } else
            {
                Instantiate(whiteBoxPrefab, spawnPoint.position, spawnPoint.rotation);
            }

        }
		
    }

}
