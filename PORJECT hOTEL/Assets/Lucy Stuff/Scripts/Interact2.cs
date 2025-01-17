using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Resources;
using UnityEngine.Serialization;
using UnityEngine.InputSystem;

public abstract class Interact2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canInteract;
    [FormerlySerializedAs("Text")] public GameObject Canvas;
    public bool noMoreE;


    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            canInteract = true;
        }
        else if (collision.gameObject.tag == "Player")
        {
            canInteract = true;
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (canInteract)
            {
                Canvas.gameObject.SetActive(false);
            }
            if (Canvas != null)
            {
                Canvas.SetActive(false);
            }
            canInteract = false;
        }
    }

    public abstract void StartInteract();

    //public virtual void yes()
    //{
    //    Canvas.SetActive(false);
    //}
    public abstract void ContinueInteract();

    public virtual void CloseInteract()
    {
        Canvas.SetActive(false);
        noMoreE = false;
        Time.timeScale = 1f;
    }

    public virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            if (Canvas != null && noMoreE == false)
            {
                noMoreE = true;
                Canvas.SetActive(true);
                Time.timeScale = 0f;

                StartInteract();
            }
        }
        if (!canInteract)
        {
            Canvas.gameObject.SetActive(false);
        }
        else if (Input.GetMouseButtonDown(0) && noMoreE)
        {
            ContinueInteract();
        }
    }
}
