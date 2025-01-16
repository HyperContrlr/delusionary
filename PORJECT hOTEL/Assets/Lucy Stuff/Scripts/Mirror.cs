using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class Mirror : MonoBehaviour
{
    public GameObject Vase;
    public GameObject Vas;
    public GameObject Vase2;
    public GameObject Vas2;
    public GameObject Painting;
    public GameObject Paint;
    public GameObject Painting2;
    public GameObject Paint2;
    public GameObject PhotoGraph;
    public GameObject Photo;
    public GameObject PhotoGraph2;
    public GameObject Photo2;

    // Start is called before the first frame update
    void Start()
    {
        // textComponent.text = string.Empty;
        Vase.SetActive(false);
        Vase2.SetActive(true);
        Vas.SetActive(true);
        Vas2.SetActive(false);
        Painting.SetActive(false);
        Painting2.SetActive(false);
        Paint.SetActive(true);
        Paint2.SetActive(true);
        PhotoGraph.SetActive(true);
        PhotoGraph2.SetActive(true);
        Photo.SetActive(false);
        Photo2.SetActive(false);
    }

    public void VaseChange()
    {
        {
            Vase.SetActive(!Vase.activeSelf);
            Vas.SetActive(!Vas.activeSelf);
            Vase2.SetActive(!Vase.activeSelf);
            Vas2.SetActive(!Vas2.activeSelf);

            Time.timeScale = 1f;
        }
    }

    public void PaintingChange()
    {
        {
            Painting.SetActive(!Painting.activeSelf);
            Paint.SetActive(!Painting.activeSelf);
            Painting2.SetActive(!Painting.activeSelf);
            Paint2.SetActive(!Painting2.activeSelf);
            Vase.SetActive(false);
            Vas.SetActive(true);

            Time.timeScale = 1f;
        }
    }

    public void PhotoGraphChange()
    {
        {
            PhotoGraph.SetActive(!PhotoGraph.activeSelf);
            Photo.SetActive(!PhotoGraph.activeSelf);
            PhotoGraph2.SetActive(!PhotoGraph.activeSelf);
            Photo2.SetActive(!PhotoGraph2.activeSelf);
            Painting.SetActive(false);
            Painting2.SetActive(false);
            Paint.SetActive(true);
            Paint2.SetActive(true);

            Time.timeScale = 1f;
        }
    }
}














//    public bool canInteract;
//    [FormerlySerializedAs("Text")] public GameObject Canvas;
//    public bool noMoreE;

//    public void OnTriggerEnter(Collider collision)
//    {
//        if (collision.gameObject.tag == "Player")
//        {
//            canInteract = true;
//        }
//        else if (collision.gameObject.tag == "Player")
//        {
//            canInteract = true;
//        }
//    }

//    public void OnTriggerExit(Collider collision)
//    {
//        if (collision.gameObject.tag == "Player")
//        {
//            if (canInteract)
//            {
//                Canvas.gameObject.SetActive(false);
//            }
//            if (Canvas != null)
//            {
//                Canvas.SetActive(false);
//            }
//            canInteract = false;
//        }
//    }

//    public virtual void CloseInteract()
//    {
//        Canvas.SetActive(false);
//        noMoreE = false;
//        Time.timeScale = 1f;
//    }

//    public void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.E) && canInteract)
//        {
//            if (Canvas != null && noMoreE == false)
//            {
//                noMoreE = true;
//                Canvas.SetActive(true);
//                Time.timeScale = 0f;

//                StartInteract();
//            }
//        }
//        if (!canInteract)
//        {
//            Canvas.gameObject.SetActive(false);
//        }
//        else if (Input.GetMouseButtonDown(0) && noMoreE)
//        {
//            ContinueInteract();
//        }
//    }
//    public TextMeshProUGUI textComponent;
//    public string[] lines;
//    public float textSpeed;
//    private int index;
//    public GameObject ChoosingPanel;
//    public bool DialougeOpened;
//    bool ChoiceTime;

//    public override void StartInteract()
//    {
//        index = 0;
//        DialougeOpened = true;

//        StartCoroutine(TypeLine());
//    }

//    public override void ContinueInteract()
//    {
//        if (!DialougeOpened)
//        {
//            StartInteract();
//        }
//        else if (textComponent.text == lines[index])
//        {
//            NextLine();
//        }
//        else
//        {
//            StopAllCoroutines();
//            textComponent.text = lines[index];
//        }
//    }

//    public override void CloseInteract()
//    {
//        Canvas.SetActive(false);
//        choiceTime();
//    }
//    public void choiceTime()
//    {
//        {
//            ChoosingPanel.gameObject.SetActive(true);
//        }
//    }

//    public void NO()
//    {
//        ChoosingPanel.gameObject.SetActive(false);
//        DialougeOpened = false;
//        Time.timeScale = 1f;
//        noMoreE = false;
//    }

//    public void NoMoreE()
//    {
//        if (noMoreE == true)
//        {
//            StartInteract();
//        }
//        else
//        {
//            return;
//        }
//    }

//    IEnumerator TypeLine()
//    {
//        textComponent.text = string.Empty;
//        foreach (char c in lines[index].ToCharArray())
//        {
//            textComponent.text += c;
//            yield return new WaitForSecondsRealtime(textSpeed);
//        }
//    }

//    void NextLine()
//    {
//        if (index < lines.Length - 1)
//        {
//            index++;
//            StartCoroutine(TypeLine());
//        }
//        else
//        {
//            CloseInteract();
//        }
//    }
//}

