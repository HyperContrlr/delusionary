using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public GameObject Vase;
    public GameObject Vase2;
    public GameObject Painting;
    public GameObject Painting2;
    public GameObject PhotoGraph;
    public GameObject PhotoGraph2;

    // Start is called before the first frame update
    void Start()
    {
        Vase.SetActive(false);
        Vase2.SetActive(true);
        Painting.SetActive(false);
        Painting2.SetActive(false);
        PhotoGraph.SetActive(false);
        PhotoGraph2.SetActive(false);
    }

    // Update is called once per frame
   // void Update()
   // {
        public void VaseChange()
    { 
        //if (VaseChange == true)
        {
            Vase.SetActive(true);
            Vase2.SetActive(false);
        }
    }
    public void PaintingChange()
    {
        //if (PaintingChange == true)
        {
            Painting.SetActive(true);
            Painting2.SetActive(true);
            Vase.SetActive(false);
        }
    }
public void PhotoGraphChange()
        { 
      // if  (PhotoGraphChange == true)
        {
            PhotoGraph.SetActive(true);
            PhotoGraph2.SetActive(true);
            Painting.SetActive(false);
            Painting2.SetActive(false);
        }
        }
    //}
}
