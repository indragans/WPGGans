using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public GameObject itemToDrop;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        if(currentHealth <= 0){
            Instantiate(itemToDrop, transform.position, Quaternion.identity);
            
            Destroy(this.gameObject);
            WaveHandler.Instance.enemyIsKilled();
        }
    }
}
