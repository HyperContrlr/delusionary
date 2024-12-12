using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Importance : Interact 
{
    public GameObject VaseLL;
    public GameObject VaseRL;
    public GameObject VaseLR;
    public GameObject VaseRR;
    public GameObject Painting;
    public GameObject Paint;
    public GameObject Painting2;
    public GameObject Paint2;
    public GameObject PhotoGraph;
    public GameObject Photo;
    public GameObject PhotoGraph2;
    public GameObject Photo2;

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject ChoosingPanel;
    public bool DialougeOpened;
    public bool ChoiceTime;

    public void Start()
    {
        textComponent.text = string.Empty;

        VaseLL.SetActive(false);
        VaseRL.SetActive(true);
        VaseLR.SetActive(true);
        VaseRR.SetActive(false);

        Painting.SetActive(false);
        Paint.SetActive(true);
        Painting2.SetActive(false);
        Paint2.SetActive(true);

        PhotoGraph.SetActive(true);
        Photo.SetActive(false);
        PhotoGraph2.SetActive(true);
        Photo2.SetActive(false);
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
            VaseLL.SetActive(!VaseLL.activeSelf);
            VaseRL.SetActive(!VaseRL.activeSelf);
            VaseLR.SetActive(!VaseLR.activeSelf);
            VaseRR.SetActive(!VaseRR.activeSelf);
            ChoiceTime = false;
            choiceTimeOver();
        }
    }

    public void PaintingChange()
    {
        {
            //Vase.SetActive(false);
            //Vas.SetActive(true);
            Painting.SetActive(!Painting.activeSelf);
            Paint.SetActive(!Paint.activeSelf);
            Painting2.SetActive(!Painting2.activeSelf);
            Paint2.SetActive(!Paint2.activeSelf);

            ChoiceTime = false;
        }
    }

    public void PhotoGraphChange()
    {
        {
            //Painting.SetActive(false);
            //Painting2.SetActive(false);
            //Paint.SetActive(true);
            //Paint2.SetActive(true);
            PhotoGraph.SetActive(!PhotoGraph.activeSelf);
            Photo.SetActive(!Photo.activeSelf);
            PhotoGraph2.SetActive(!PhotoGraph2.activeSelf);
            Photo2.SetActive(!Photo2.activeSelf);

            ChoiceTime = false;
        }
    }

    //public void Win()
    //{
    //    if (Vase.SetActive(true) && Vas.SetActive(true) && Painting.SetActive(false) && Paint2.SetActive(false) && PhotoGraph(true) && Photo.SetActive(true) ) 
    //    {

    //    }
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
