using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
             collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
        //Destroy(gameObject);
    }
}
