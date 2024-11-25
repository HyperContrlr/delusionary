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
    public void Start()
    {
        textComponent.text = string.Empty;
        StartDialoug();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            if (Text != null)
            {
                Text.SetActive(true);
            }
        }
        if (!canInteract)
        {
            Text.gameObject.SetActive(false);
        }
    }
    void StartDialoug()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
