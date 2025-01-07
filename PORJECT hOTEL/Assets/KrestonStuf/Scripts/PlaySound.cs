using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource Interact;

    public void playInteract()
    {
        Interact.Play();
    }
}
