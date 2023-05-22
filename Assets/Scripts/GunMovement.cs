using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour
{
    
    public float moveSpeed = 10f;

    //public Rigidbody2D rb;
    private Camera cam;

    //Vector2 movement;
    Vector2 mousePos;

    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //transform.position = GetComponentInParent<Transform>().position;
        //Debug.Log(GetComponentInParent<Transform>().position);

        Vector2 lookDir = mousePos - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;


        transform.eulerAngles = new Vector3(0, 0, angle);
        if (transform.eulerAngles.z >= 0 && transform.eulerAngles.z < 180) GetComponent<SpriteRenderer>().flipX = true;
        else GetComponent<SpriteRenderer>().flipX = false;
    }

}
