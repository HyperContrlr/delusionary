using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDaDoor : MonoBehaviour
{
    private Animator animator;
    public bool canOpen;
    public float animDuration;
    private void Start()
    {
        canOpen = false;
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    public void Update()
    {
        //checks if the player can open it
        if (Input.GetKeyDown(KeyCode.E) && canOpen)
        {
            StartCoroutine(DoorAnimationTimer());
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canOpen = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        canOpen = false;
    }

    private IEnumerator DoorAnimationTimer()
    {
        canOpen = false;
        //Play the open door animation
        animator.SetTrigger("open");
        //disable hitbox
        this.GetComponent<BoxCollider>().enabled = false;
        //start a timer
        yield return new WaitForSeconds(animDuration);
        //enable hitbox again
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
        //play the close animation
        animator.SetTrigger("close");
    }
}
