using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    //☈ΩΞϟΨ
    private bool clickable = false;
    private bool complete = false;
    private bool click1 = false;
    private bool click2 = false;
    private char key1 = 'x';
    private char key2 = 'x';

    public void afterClick2()
    {

        if ((key1 == '5') && (key2 == 'l'))
        {
            complete = true;
            clickable = false;
        }
        else
        {
            key1 = 'x';
            key2 = 'x';
            click1 = false;
            click2 = false;
            clickable = true;

        }
    }
    public void onSquareClick()
    {
        if (clickable = true)
        {
            clickable = false;
            
            //char #1
            if (click1 = false)
            {
                click1 = true;
                //key1 = '';
                clickable = true;
            }
            //char#2
            if ((click1 = true) && (click2 = false))
            {
                click2 = true;
                //key2 = '';
                afterClick2();
            }
        }
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
