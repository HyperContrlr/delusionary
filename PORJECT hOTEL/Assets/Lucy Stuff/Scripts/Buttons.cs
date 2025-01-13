using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Animator Animation; 

    public void playbutton()
    {
        StartCoroutine(Play());
    }
    public IEnumerator Play()
    {
        Animation.SetTrigger("FadeTobLAck");
        yield return new WaitForSeconds(2F);
        SceneManager.LoadScene("MasterScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void credits()
    {
        SceneManager.LoadScene("credits");
    }

}
