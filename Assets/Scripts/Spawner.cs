using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pauseScreen;
    public float levelRateInSeconds;
    public float enemySpeed;
    public GameObject enemyPrefab;
    public float[] spawnRatesInSeconds;
    public Vector3 minSpawnPoint;
    public Vector3 maxSpawnPoint;
    
    float pausedTime;
    bool isPaused;
    int level = 1;
    float spawnRate;
    float lastSpawnTimeStamp;

    private void Start()
    {
        spawnRate = spawnRatesInSeconds[level - 1];
        Enemy.actualSpeed = enemySpeed;
        lastSpawnTimeStamp = 0;
        Time.timeScale = 1;
    }

    private void Update()
    {
        float gameTime = Time.timeSinceLevelLoad - pausedTime;
        print(gameTime);
        if (gameTime >= lastSpawnTimeStamp + spawnRate)
        {
            float spawnPositionX = Random.Range(minSpawnPoint.x, maxSpawnPoint.x);
            float spawnPositionY = Random.Range(minSpawnPoint.y, maxSpawnPoint.y);
            float spawnPositionZ = Random.Range(minSpawnPoint.z, maxSpawnPoint.z);
            Vector3 spawnPosition = new Vector3(spawnPositionX, spawnPositionY, spawnPositionZ);
            Instantiate(enemyPrefab, transform.position + spawnPosition, Quaternion.identity, transform);
            lastSpawnTimeStamp = gameTime;
        }
        if(isPaused)
        {
            pausedTime += Time.deltaTime;
        }
        else if(gameTime > level * levelRateInSeconds)
        {
            if(level <= spawnRatesInSeconds.Length)
            {
                level = level + 1;
                spawnRate = spawnRatesInSeconds[level - 1];
            }
        }
    }

    public void Pause()
    {
        isPaused = true;
        pauseScreen.SetActive(true);
        Enemy.actualSpeed = 0;
    }

    public void Resume()
    {
        isPaused = false;
        pauseScreen.SetActive(false);
        Enemy.actualSpeed = enemySpeed;
    }
}
