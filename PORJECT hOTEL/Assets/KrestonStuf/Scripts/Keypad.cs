using System.Collections;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    //☈ΩΞϟΨ
    public bool clickable = true;
    public bool complete = false;
    public bool click1 = false;
    public char key1 = ' ';
    public char key2 = ' ';
    public string VMText = string.Empty;
    public int delayTime = 5;
    public TMPro.TMP_Text digits;


    public void afterClick2()
    {
        if ((key1 == '5') && (key2 == 'ϟ'))
        {
            complete = true;
            clickable = false;
        }
        else
        {
            
            key1 = ' ';
            key2 = ' ';
            digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            click1 = false;
            clickable = true;
        }
    }
    public void onSquareClick() 
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = '☈';
                clickable = true;

                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = '☈';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void onOmegaClick()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = 'Ω';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = 'Ω';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void onLinesClick()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = 'Ξ';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = 'Ξ';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void onBoltClick()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = 'ϟ';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = 'ϟ';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void onForkClick()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = 'Ψ';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = 'Ψ';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void on1Click()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = '1';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = '1';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void on2Click()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = '2';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = '2';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void on3Click()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = '3';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = '3';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void on4Click()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = '4';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = '4';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    public void on5Click()
    {
        if (clickable == true)
        {
            if ((click1 == false))
            {
                click1 = true;
                key1 = '5';
                clickable = true;
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
            else
            {
                key2 = '5';
                StartCoroutine(TimeBeforeReset());
                digits.SetText(char.ToString(key1) + char.ToString(key2).ToString());
            }
        }
    }
    IEnumerator TimeBeforeReset()
    {
        clickable = false;
        //VMText = char.ToString(key1) + char.ToString(key2);
        print(Time.time);
        yield return new WaitForSeconds(delayTime);
        print(Time.time);
        afterClick2();
    }
}
