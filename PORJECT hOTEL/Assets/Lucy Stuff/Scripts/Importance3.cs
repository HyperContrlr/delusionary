using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Importance3 : Interact
{
    public bool DialougeOpened;
    public GameObject KeyPad;
    

    public override void Update()
    {
        base.Update();
       // Winning();
    }

    public override void StartInteract()
    {
        DialougeOpened = true;

        KeyPad.SetActive(true);
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
        KeyPad.SetActive(false);
    }

    

    public void NO()
    {
        DialougeOpened = false;
        Time.timeScale = 1f;
        noMoreE = false;
        KeyPad.SetActive(false);
    }

    //public void Winning()
    //{
    //    if (DP.Light1.enabled == true && DP.Light2.enabled == false && DP.Light3.enabled == true && DP.Light4.enabled == false && DP.Light5.enabled == true)
    //    {
    //        Debug.Log("puzzle finished");
    //        //     PuzzlePeice.SetActive(true);
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



}

