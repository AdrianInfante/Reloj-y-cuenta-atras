using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public bool playCountDown;
    public int minutes;
    public int seconds;
    public TextMeshPro timer;


    private void Start()
    {
        StartCoroutine(countdown());
    }


    IEnumerator countdown()
    {
        while(playCountDown == true)
        {
            if(seconds > 0)
            {
                seconds--;
                yield return new WaitForSeconds(1.0f);
            
            }
            else
            {
                seconds = 60;
                minutes--;
            }

            timer.text = string.Format("{00:00}:{01:00}", minutes, seconds);

            if(minutes == 0 && seconds == 0)
            {
                playCountDown = false;
            }
        }
    }
}
