using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour{
    public Transform player;
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start(){
        rb = this.GetComponent<Rigidbody2D>();
        sprite = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update(){
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate() {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        if(direction.x < 0)
        {
            sprite.flipX = false;
        }
        else 
        {
            sprite.flipX = true;
        }

    }

    public void setPlayerPost(Transform players)
    {
        player = players;
    }
}
