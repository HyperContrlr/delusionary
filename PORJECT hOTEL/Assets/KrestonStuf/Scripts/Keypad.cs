using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    //☈ΩΞϟΨ
    private bool clickable = true;
    private bool complete = false;
    private bool click1 = false;
    private bool click2 = false;
    private char key1 = 'x';
    private char key2 = 'x';
    public string VMText = string.Empty;

    public void afterClick2()
    {
        if ((key1 == '5') && (key2 == 'l'))
        {
            complete = true;
            clickable = false;
            VMText = char.ToString(key1) + char.ToString(key2);
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
        if (clickable = true && (click1 = true) && (click2 = false))
        {
            click2 = true;
            key2 = '☈';
            afterClick2();
        }
        if (clickable = true && (click1 = false))
        {
            click1 = true;
            key1 = '☈';
            clickable = true;
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
    public void onForkClick()
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
    public void on5Click()
    {

    }
}
