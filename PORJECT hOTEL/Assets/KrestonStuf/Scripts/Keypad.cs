using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    private bool complete = false;
    private bool click1 = false;
    private bool click2 = false;
    private char key1 = 'x';
    private char key2 = 'x';

    public void afterClick2()
    {
        if ((click1 = true) && (click2 = true))
        {
            if ((key1 == '5') && (key2 == 'l'))
            {
                complete = true;
            }
            else
            {
                key1 = 'x';
                key2 = 'x';
                click1 = false;
                click2 = false;
            }
        }
    }
    public void onSquareClick()
    {

    }
    public void onOmegaClick()
    {

    }
    public void onLinesClick()
    {

    }
    public void onBoltClick()
    {

    }
    public void on1Click()
    {

    }
    public void on2Click()
    {

    }
    public void on3Click()
    {

    }
    public void on4Click()
    {

    }
}
