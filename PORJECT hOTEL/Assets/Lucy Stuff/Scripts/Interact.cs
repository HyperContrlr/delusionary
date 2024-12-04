using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Resources;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canInteract;
    public GameObject Text;
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
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
    bool DialougeOpened;

    void StartDialoug()
    {
        index = 0;
        DialougeOpened = true;
       
        StartCoroutine(TypeLine());
    }
    //public void Pause()
    //{
       // Time.timeScale = 0f;
//}
    //public void ResumeEffect()
    //{
    //    Time.timeScale = 1f;

    //}

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (canInteract)
            {
                Text.gameObject.SetActive(false);
            }
            if (Text != null)
            {
                Text.SetActive(false);
            }
            canInteract = false;
        }
    }
    public void NoMoreE()
    {
        if (noMoreE == true)
        {        
            StartDialoug();
            
        }
        else
        {
            return;
        }
    }
   
    public void Start()
    {
        textComponent.text = string.Empty;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            if (Text != null && noMoreE == false)
            {
                noMoreE = true;
                Text.SetActive(true);
                StartDialoug();
                Time.timeScale = 0f;

            }
        }
        if (!canInteract)
        {
            Text.gameObject.SetActive(false);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            if(!DialougeOpened)
            {
                StartDialoug();
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
            Text.SetActive(false);
            DialougeOpened = false; 
            noMoreE = false;
            Time.timeScale = 1f;
        }
    }
}
