using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;


    private void OnCollisionEnter2D(Collision2D collision)
    { 
        PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        if(playerHealth != null) 
        {
            playerHealth.TakeDamage(damage);
            playerHealth.PlayFeedback(gameObject);
        }
    }
}
