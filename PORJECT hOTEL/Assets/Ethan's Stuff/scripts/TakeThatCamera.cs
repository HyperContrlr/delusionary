using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TakeThatCamera : MonoBehaviour
{
    public GameObject player;
    public GameObject thisThing;
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mainCamera.gameObject.GetComponent<smoothCameraFollow>().target = thisThing.transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mainCamera.gameObject.GetComponent<smoothCameraFollow>().target = player.transform;
        }
    }
}
