using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public IEnumerator Play()
    {
        yield return new WaitForSeconds(2);
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
