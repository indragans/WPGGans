using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Ngapain?");

            //PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
            CountResources playerResources = other.GetComponent<CountResources>();
            playerResources.resourcesCount++;
            //playerHealth.health++;

            Destroy(gameObject);
        }
    }
}
