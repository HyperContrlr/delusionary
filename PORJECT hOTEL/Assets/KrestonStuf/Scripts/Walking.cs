using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Serialization;

[Serializable]
public struct variations
{
    public List<AudioClip> Audio;
}

public class Walking : MonoBehaviour
{
    private enum TerrainTags
    {
        Tile,
        Void
    }

    [SerializeField]
    private variations[] footstepAudios;

    private AudioSource audioSource;

    private float footstepTimer;
    private float timePerStep = 0.5f;

    private List<AudioClip> currentAudio;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        footstepTimer += Time.deltaTime;
        if ((this.GetComponent<speedometer>().speed > 0) && footstepTimer > timePerStep )
        {
            audioSource.clip = currentAudio[UnityEngine.Random.Range(0, currentAudio.Count)];
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
                currentAudio = footstepAudios[index].Audio;

            }
            index++;
        }
    }
}