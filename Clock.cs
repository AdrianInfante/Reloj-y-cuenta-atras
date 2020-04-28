using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{


    public bool showCurrentTime;
    public TextMeshPro timer;


    private void Start()
    {
        StartCoroutine(currentTime());
    }


    IEnumerator currentTime()
    {
        while(showCurrentTime == true)
        {
            timer.text = System.DateTime.Now.ToShortTimeString();
            yield return null;
        }
    }
}
