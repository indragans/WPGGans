using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public QuestManajer questManajer;
    public GameObject/*[]*/ itemToDropArray;    //list enemy
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        questManajer = GameObject.FindObjectOfType<QuestManajer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        if(currentHealth <= 0){
            //Instantiate(itemToDropArray[Random.Range(0, itemToDropArray.Length - 1)], transform.position, Quaternion.identity);
            Instantiate(itemToDropArray, transform.position, Quaternion.identity);

            Destroy(this.gameObject);
            WaveHandler.Instance.enemyIsKilled();
            questManajer.EnemyDefeated();
        }
    }
}
