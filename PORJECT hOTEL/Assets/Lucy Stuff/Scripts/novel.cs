//using System;
//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine.InputSystem;
//using UnityEngine.InputSystem.iOS;
//using UnityEngine;

//public class novel : MonoBehaviour
//{
//    public TextMeshProUGUI textComponent;
//    public string[] lines;
//    public float textSpeed;
//    private int index;
//    public GameObject VN;
//    public GameObject Starting;
//    public GameObject change1;
//    public GameObject change2;
//    bool DialougeOpened;

//    //[FormerlySerializedAs("Text")] public GameObject Canvas;



//    public virtual void Update()
//    {
//        //if (Input.GetKeyDown(KeyCode.E) && canInteract)
//        //{
//        //    if (Canvas != null && noMoreE == false)
//        //    {
//        //        noMoreE = true;
//        //        Canvas.SetActive(true);
//        //        Time.timeScale = 0f;

//        //        StartInteract();
//        //    }
//        //}
//        //if (!canInteract)
//        //{
//        //    Canvas.gameObject.SetActive(false);
//        //}
//        if (Input.GetMouseButtonDown(0))
//        {
//            ContinueInteract();
//        }

//        Change();
//        Change2();

//    }

//    public void Start()
//    {
//        textComponent.text = string.Empty;
//        StartInteract();
//    }

//    public void StartInteract()
//    {
//        index = 0;
//        DialougeOpened = true;
//        Time.timeScale = 0f;
//        StartCoroutine(TypeLine());
//        Starting.SetActive(true);
//    }

//    void Change()
//    {
//    if (index == 2)
//        {
//            Starting.SetActive(false);
//            change1.SetActive(true);
//        }
//    }

//    void Change2()
//    {
//        if (index == 4)
//        {
//            change1.SetActive(false);
//            change2.SetActive(true);
//        }
//    }

//    public void ContinueInteract()
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

//    public void CloseInteract()
//    {
//        VN.SetActive(false);
//        DialougeOpened = false;
//        Time.timeScale = 1f;
//    }

//    //public void NoMoreE()
//    //{
//    //    if (noMoreE == true)
//    //    {
//    //        StartInteract();
//    //    }
//    //    else
//    //    {
//    //        return;
//    //    }
//    //}

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
