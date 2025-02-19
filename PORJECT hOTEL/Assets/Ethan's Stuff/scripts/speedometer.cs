using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class speedometer : MonoBehaviour
{
    public float speed;
    public TMP_Text speedomtr;

    private void Start()
    {
        StartCoroutine(CalcSpeed());
    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;
        while (isPlaying)
        {
            Vector3 prevPos = transform.position;
            yield return new WaitForFixedUpdate();
            speed = Mathf.Round/*&ToInt*/(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
            //speedomtr.text = speed.ToString();
        }
    }
}
