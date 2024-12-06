using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Importance : Interact
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject ChoosingPanel;
    bool DialougeOpened;
    bool ChoiceTime;

    public void Start()
    {
        textComponent.text = string.Empty;
    }

    public override void StartInteract()
    {
        index = 0;
        DialougeOpened = true;

        StartCoroutine(TypeLine());
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
        Canvas.SetActive(false);
        choiceTime();
    }
    public void choiceTime()
    { 
        {
            ChoosingPanel.gameObject.SetActive(true);   
        }
    }

    public void NO()
    {
        ChoosingPanel.gameObject.SetActive(false);
        DialougeOpened = false;
        Time.timeScale = 1f;
        noMoreE = false;
    }
    //public void YESVaseChange()
    //{

    //}
    //public void YESPaintingChange()
    //{

    //}
    //public void YESPhotoGraphChange()
    //{

    //}

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
