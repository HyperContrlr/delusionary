using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDaDoor : MonoBehaviour
{
    public bool canOpen;
    public int animDuration;
    private void Start()
    {
        canOpen = false;
    }
    // Update is called once per frame
    void Update()
    {
        //checks if the player can open it
        if (canOpen && Input.GetKeyDown(KeyCode.E))
        {
            //Play the open door animation
            //disable hitbox
            //start a timer
            System.Threading.Thread.Sleep(animDuration);
            //play the close animation
            //enable hitbox again
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canOpen = true;
        }
    }
}
