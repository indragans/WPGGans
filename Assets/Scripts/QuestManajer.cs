using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;
using System;

public class QuestManajer : MonoBehaviour
{
    public int totalEnemies = 14;
    public int enemiesDefeated = 0;
    public bool questCompleted = false;

    public TextMeshProUGUI questText;
    public TextMeshProUGUI enemyCountText;

    public string sceneToLoad;
    // Start is called before the first frame update
    private void Start()
    {
        questText.text = "Selesaikan Quest! \n \nBunuh semua monster dan kumpulkan sampah" ;
        UpdateEnemyCountText();
    }

    // Update is called once per frame
    public void EnemyDefeated()
    {
        enemiesDefeated++;
        UpdateEnemyCountText();

        if(enemiesDefeated >= totalEnemies)
        {
            questCompleted = true;
            questText.text = "Quest Selesai";
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            GameWon();
        }
    }

    private void UpdateEnemyCountText()
    {
        enemyCountText.text = "Musuh : " + enemiesDefeated + " / " + totalEnemies;
    }

    public void GameWon(){
        //Thread.Sleep(TimeSpan.FromSeconds(5));
        SceneManager.LoadScene(sceneToLoad);
    }
}
