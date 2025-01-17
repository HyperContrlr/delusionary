using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject Canvas1;
    public GameObject Canvas2;
    public GameObject Canvas3;
    public GameObject Canvas4;
    public GameObject Canvas5;
    public GameObject Canvas6;

    public void Press1()
    {
        Canvas1.SetActive(true);
    }
    public void Press2()
    {
        Canvas2.SetActive(true);
    }
    public void Press3()
    {
        Canvas3.SetActive(true);
    }
    public void Press4()
    {
        Canvas4.SetActive(true);
    }
    public void Press5()
    {
        Canvas5.SetActive(true);
    }
    public void Press6()
    {
        Canvas6.SetActive(true);
    }
      

    public void UnPress()
    {
        Canvas1.SetActive(false);
        Canvas2.SetActive(false);
        Canvas3.SetActive(false);
        Canvas4.SetActive(false);
        Canvas5.SetActive(false);
        Canvas6.SetActive(false);
    }
}
