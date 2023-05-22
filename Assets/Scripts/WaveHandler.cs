using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveHandler : MonoBehaviour
{
    public static WaveHandler Instance;
    public List<Transform> spawnPost;
    public Wave currentWave;
    public Transform playerPost;
    private int enemyTemp;
   // private int currentEnemyInWave;
    
    private void Awake() {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start() {
        for(int i = 0; i < currentWave.enemyPerWave; i++)
        {
        GameObject enemy = Instantiate(currentWave.enemy[Random.Range(0, currentWave.enemy.Count)], spawnPost[Random.Range(0, spawnPost.Count)].position, Quaternion.identity);
        enemy.GetComponent<EnemyFollow>().setPlayerPost(playerPost);
        enemyTemp = currentWave.enemyPerWave;
        }
    }
private void Update() {
    if(currentWave.nextWave != null)
    {
    if(enemyTemp == 0)
    {
        StartnextWave();
    }
    }
}
    private void StartnextWave()
    {
        currentWave = currentWave.nextWave;
 for(int i = 0; i < currentWave.enemyPerWave; i++)
        {
        GameObject enemy = Instantiate(currentWave.enemy[Random.Range(0, currentWave.enemy.Count)], spawnPost[Random.Range(0, spawnPost.Count)].position, Quaternion.identity);
        enemy.GetComponent<EnemyFollow>().setPlayerPost(playerPost);
        enemyTemp = currentWave.enemyPerWave;
        }
    }
    
    public void enemyIsKilled()
    {
        enemyTemp--;
    }
}
