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
}
