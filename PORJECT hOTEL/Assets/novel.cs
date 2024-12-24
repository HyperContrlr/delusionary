using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.iOS;
using UnityEngine;

public class novel : Interact
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject change1;
    public GameObject change2;
    bool DialougeOpened;

    public void Start()
    {
        textComponent.text = string.Empty;
        StartInteract();
    }

    public override void StartInteract()
    {
        index = 0;
        DialougeOpened = true;
        Time.timeScale = 0f;
        StartCoroutine(TypeLine());
    }

    void Change()
    {
    if (index == 2)
        {
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
        DialougeOpened = false;
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
