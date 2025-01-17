using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheEnd : Interact2
{
    public GameObject FinalDoor;
    public GameObject AC;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    public GameObject VN;
    public GameObject Starting;
    public GameObject change1;
    public GameObject change2;
    bool DialougeOpened;
    public Animator Animation;
    private InventoryManager inventoryManager;

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
        Change2();
        

    }


    public void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

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

    void Change2()
    {
        if (index == 4)
        {
            change1.SetActive(false);
            change2.SetActive(true);
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
            StartCoroutine(Enddd());
        }
    }
    public IEnumerator Enddd()
    {
        Animation.SetTrigger("FadeTobLAck");
        yield return new WaitForSeconds(5F);
        SceneManager.LoadScene("Master Credits");
    }
    public void FixedUpdate()
    {
        if (inventoryManager.puzzle1 && inventoryManager.puzzle3 && inventoryManager.puzzle2)
        {
            FinalDoor.SetActive(true);
            AC.SetActive(false);
        }
    }
}
