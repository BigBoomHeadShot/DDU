using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] GameObject SeekerW;
    [SerializeField] GameObject RestartMenu;
    public float timeRemaining;
    int minutes;
    int seconds;
    string subSec;
    [SerializeField] TMP_Text timerText;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            minutes = ((int)(timeRemaining / 60));
            seconds = (int)(timeRemaining - (minutes * 60));
            if (seconds < 10)
            {
                subSec = "0";
            }
            else
            {
                subSec = "";
            }
            timerText.text = "Time to Live: " + minutes + ":" + subSec + seconds;
        }
        else
        {
            SeekerW.SetActive(true);
            RestartMenu.SetActive(true);
        }
    }

    
}
