using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Dialogue : Interact
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    
    bool DialougeOpened;

    TheControls controls;
    private InputActionReference interact_action;
    private void Awake()
    {
        //For now, assigns the controls
        controls = new TheControls();
    }
    private void OnEnable()
    {
        interact_action.action.started += Interact_started;
    }
    private void OnDisable()
    {
        interact_action.action.started -= Interact_started;
    }
    private void Interact_started(InputAction.CallbackContext obj)
    {

    }
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
