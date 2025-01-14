using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Serialization;

public class Walking : MonoBehaviour
{
    private enum TerrainTags
    {
        Carpet,
        Tile,
        Void
    }

    [SerializeField]
    private AudioClip[] footstepAudios;

    private AudioSource audioSource;

    private float footstepTimer;
    private float timePerStep = 0.5f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        footstepTimer += Time.deltaTime;
        if ((this.GetComponent<speedometer>().speed > 0) && audioSource.clip && footstepTimer > timePerStep )
        {
            audioSource.Play();
            footstepTimer = 0;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        int index = 0;
        foreach(string tag in Enum.GetNames(typeof(TerrainTags)))
        {
            if(col.gameObject.tag == tag)
            {
                audioSource.clip = footstepAudios[index];

            }
            index++;
        }
    }
}