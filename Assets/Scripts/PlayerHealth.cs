using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public GameManagerScript gameManager;
    public int maxHealth;
    public int health;

    public float strength = 16f, delay = 0.15f;

    public SpriteRenderer playerSr;
    public PlayerMovement playerMovement;

    private new Rigidbody2D rigidbody2D;

    public UnityEvent OnBegin, OnDone;

    //private bool isDead;

    void Start()
    {
        health = maxHealth;
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    public void TakeDamage(int damage){
        health -= damage;
        if(health <= 0){
            playerSr.enabled = false;
            playerMovement.enabled = false;

            //isDead=true;
            //gameObject.SetActive(false);
            Destroy(gameObject);
            //gameManager.gameOver();
        }
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(delay);
        rigidbody2D.velocity = Vector2.zero;
        OnDone?.Invoke();
    }

    public void PlayFeedback(GameObject sender)
    {
        Debug.Log("Hehe");
        
        StopAllCoroutines();
        OnBegin?.Invoke();
        Vector2 direction = (transform.position - sender.transform.position).normalized;
        Debug.Log(direction);

        transform.position += new Vector3(direction.x * strength, direction.y * strength, 0);

        // rigidbody2D.AddForce(direction * strength, ForceMode2D.Impulse);
        StartCoroutine(Reset());
    }

    
}
