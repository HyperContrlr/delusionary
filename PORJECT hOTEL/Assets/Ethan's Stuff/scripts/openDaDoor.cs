using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class openDaDoor : MonoBehaviour
{
    public AudioSource OpenSound;

    public InventoryManager inventoryManager;
    private Animator animator;
    public bool canOpen;
    public float animDuration;
    public bool isLocked;
    public string unlockID;
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
        if (!isLocked)
        {
            if (Input.GetKeyDown(KeyCode.E) && canOpen)
            {
                //Play the open door animation
                animator.SetTrigger("open");
                //Play the door sound
                OpenSound.Play();
                //start coroutine
                StartCoroutine(DoorAnimationTimer());
            }
        }
        else if (isLocked)
        {
            if (unlockID == "1" && inventoryManager.puzzle1)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());
            }
            if (unlockID == "2" && inventoryManager.puzzle2)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());
            }
            if (unlockID == "3" && inventoryManager.puzzle3)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());
            }
            if (unlockID == "4" && inventoryManager.doll1)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());
            }
            if (unlockID == "5" && inventoryManager.doll2)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());
            }
            if (unlockID == "6" && inventoryManager.doll3)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());
            }
            if (unlockID == "7" && inventoryManager.keycard1)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());
            }
            if (unlockID == "8" && inventoryManager.keycard2)
            {
                isLocked = false;
                //animator.SetTrigger("open");
                //StartCoroutine(DoorAnimationTimer());4
            }
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
