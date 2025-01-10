using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Dollpuzzle : MonoBehaviour
{
    public Image Light1;
    public Image Light2;
    public Image Light3;
    public Image Light4;
    public Image Light5;

    public void button1()
    {
        Light1.enabled = !Light1.enabled;
    }

    public void button2()
    {
        Light2.enabled = !Light2.enabled;
    }

    public void button3()
    {
        Light3.enabled = !Light3.enabled;
    }

    public void button4()
    {
        Light4.enabled = !Light4.enabled;
    }

    public void button5()
    {
        Light5.enabled = !Light5.enabled;
    }
}
