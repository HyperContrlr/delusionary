using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine;

public class PoloroidInteract : Interact2
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject VN;
    public GameObject Starting;
    public GameObject change1;
    bool DialougeOpened;

    public virtual void Update()
    {
        base.Update();
        if (DialougeOpened == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ContinueInteract();
            }
        }
        Change();

    }

    //public void Start()
    //{

    //}

    public override void StartInteract()
    {

        Time.timeScale = 0f;

    }

    public void yes()
    {
        textComponent.text = string.Empty;
        index = 0;
        DialougeOpened = true;
        StartCoroutine(TypeLine());
        Starting.SetActive(true);
        VN.SetActive(true);
    }

    void Change()
    {
        if (index == 2)
        {
            Starting.SetActive(false);
            change1.SetActive(true);
        }
    }

    public override void ContinueInteract()
    {
        if (!DialougeOpened)
        {
            StartInteract();
        }
        else if (textComponent.text == lines[index])
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            textComponent.text = lines[index];
        }
    }

    public override void CloseInteract()
    {
        base.CloseInteract();
        VN.SetActive(false);
        DialougeOpened = false;
        Time.timeScale = 1f;
    }

    public void NoMoreE()
    {
        if (noMoreE == true)
        {
            StartInteract();
        }
        else
        {
            return;
        }
    }

    IEnumerator TypeLine()
    {
        textComponent.text = string.Empty;
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSecondsRealtime(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            StartCoroutine(TypeLine());
        }
        else
        {
            CloseInteract();
        }
    }
}
