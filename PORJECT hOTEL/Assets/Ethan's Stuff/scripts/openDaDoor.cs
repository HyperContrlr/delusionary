using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        this.transform.position = Vector3.zero;
        //checks if the player can open it
        if (Input.GetKeyDown(KeyCode.E) && canOpen)
        {
            //Play the open door animation
            animator.SetTrigger("open");
            //start coroutine
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
