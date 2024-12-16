using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Importance : Interact 
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject ChoosingPanel;
    public bool DialougeOpened;
    public bool ChoiceTime;
    public GameObject PuzzlePeice;

    public void Start()
    {
        textComponent.text = string.Empty;
        Win();
    }
    //public override void Update()
    //{
    //    base.Update();

    //}

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
        ChoiceTime = true;
        choiceTime();
    }
    public void choiceTime()
    {
        if (ChoiceTime == true)
        {
            ChoosingPanel.SetActive(true);   
        }
    }

    public void choiceTimeOver()
    {
        if (ChoiceTime == false)
        {
            Time.timeScale = 1f;
            DialougeOpened = false;
            noMoreE = false;
            ChoosingPanel.gameObject.SetActive(false);
        }
    }

    public void NO()
    {
        DialougeOpened = false;
        Time.timeScale = 1f;
        noMoreE = false;
        ChoosingPanel.gameObject.SetActive(false);
    }
    public void VaseChange()
    {
        {
            ObjectSetup.VaseLL.SetActive(!ObjectSetup.VaseLL.activeSelf);
            ObjectSetup.VaseRL.SetActive(!ObjectSetup.VaseRL.activeSelf);
            ObjectSetup.VaseLR.SetActive(!ObjectSetup.VaseLR.activeSelf);
            ObjectSetup.VaseRR.SetActive(!ObjectSetup.VaseRR.activeSelf);

            ChoiceTime = false;
            choiceTimeOver();
            canInteract = false;
        }
    }

    public void PaintingChange()
    {
        {
            ObjectSetup.VaseLL.SetActive(true);
            ObjectSetup.VaseRL.SetActive(false);
            ObjectSetup.PaintingLL.SetActive(!ObjectSetup.PaintingLL.activeSelf);
            ObjectSetup.PaintingRL.SetActive(!ObjectSetup.PaintingRL.activeSelf);
            ObjectSetup.PaintingLR.SetActive(!ObjectSetup.PaintingLR.activeSelf);
            ObjectSetup.PaintingRR.SetActive(!ObjectSetup.PaintingRR.activeSelf);

            ChoiceTime = false;
            choiceTimeOver();
            canInteract = false;
        }
    }

    public void PhotoGraphChange()
    {
        {
            ObjectSetup.PaintingLL.SetActive(false);
            ObjectSetup.PaintingRL.SetActive(true);
            ObjectSetup.PaintingLR.SetActive(true);
            ObjectSetup.PaintingRR.SetActive(false);
            ObjectSetup.PhotoGraphLL.SetActive(!ObjectSetup.PhotoGraphLL.activeSelf);
            ObjectSetup.PhotoGraphRL.SetActive(!ObjectSetup.PhotoGraphRL.activeSelf);
            ObjectSetup.PhotoGraphLR.SetActive(!ObjectSetup.PhotoGraphLR.activeSelf);
            ObjectSetup.PhotoGraphRR.SetActive(!ObjectSetup.PhotoGraphRR.activeSelf);

            ChoiceTime = false;
            choiceTimeOver();
            canInteract = false;
        }
    }

    public void Win()
    {
        if (ObjectSetup.VaseRL.activeSelf == true && ObjectSetup.VaseRR.activeSelf == true && ObjectSetup.PaintingLL.activeSelf == true && ObjectSetup.PaintingRR.activeSelf == true && ObjectSetup.PhotoGraphLL.activeSelf == true && ObjectSetup.PhotoGraphLR.activeSelf == true)
        {
            Debug.Log("puzzle finished");
            PuzzlePeice.SetActive(true);
        }
    }

    public void Won()
    {
        PuzzlePeice.SetActive(true);
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
