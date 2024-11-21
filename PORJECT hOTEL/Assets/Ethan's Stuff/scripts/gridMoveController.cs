using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridMoveController : MonoBehaviour
{
    private float currentMoveSpeed;
    public float moveSpeed;
    public float sprintSpeed;
    public Transform movePoint;
    public LayerMask moveStopper;
    public bool hasSprintShoes = false;
    
    public KeyCode sprint;
    public KeyCode interact;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(sprint) && hasSprintShoes)
        {
            currentMoveSpeed = sprintSpeed;
        }
        else
        {
            currentMoveSpeed = moveSpeed;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, currentMoveSpeed * Time.deltaTime);
        if(Vector3.Distance(transform.position, movePoint.position) <= .05)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, moveStopper))
                {
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                }
            }
            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, moveStopper))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                }
            }
        }
    }
    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKeyDown(interact))
        {
            if (collision.gameObject.CompareTag("NPC"))
            {
                Console.WriteLine("WORKS");
            }
        }
    }*/

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if (Input.GetKeyDown(interact))
        //{
            
            if (collision.gameObject.CompareTag("NPC"))
            {
                // Handle NPC interaction here
                // For example, you could open a dialogue window or start a battle
                Debug.Log("Interacting with NPC: " + collision.gameObject.name);
            }/*
            else if (collision.gameObject.CompareTag("Item"))
            {
                // Handle item interaction here
                // For example, you could add the item to the player's inventory or use it immediately
                Debug.Log("Interacting with item: " + collision.gameObject.name);
            }
            else if (collision.gameObject.CompareTag("Encounter"))
            {
                // Handle encounter interaction here
                // For example, you could start a random encounter with a wild Pokemon
                //Debug.Log("Encountering wild Pokemon: " + collision.gameObject.name);
            }*/
        //}
    }
}
