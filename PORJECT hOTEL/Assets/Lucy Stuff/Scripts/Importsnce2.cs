using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Importsnce2 : Interact
{
    public Dollpuzzle DP;
    public bool DialougeOpened;
    public GameObject PuzzlePeice;

    public void Start()
    {
        // Win();
    }

    public override void StartInteract()
    {
        DialougeOpened = true;

        //StartCoroutine(TypeLine());
    }

    public override void ContinueInteract()
    {
        if (!DialougeOpened)
        {
            StartInteract();
        }
        //else if (textComponent.text == lines[index])
        //{
        //    NextLine();
        //}
        //else
        //{
        //    StopAllCoroutines();
        //    textComponent.text = lines[index];
        //}
    }

    public override void CloseInteract()
    {
        Canvas.SetActive(false);
        Time.timeScale = 1f;
        DialougeOpened = false;
        noMoreE = false;
    }

    public void NO()
    {
        DialougeOpened = false;
        Time.timeScale = 1f;
        noMoreE = false;
    }

    public void Win()
    {
        if (DP.Light1.enabled == true && DP.Light3.enabled == true && DP.Light5.enabled == true)
        {
            Debug.Log("puzzle finished");
            //     PuzzlePeice.SetActive(true);
        }
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

 

}

