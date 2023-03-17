using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float timeRemaining;
    int minutes;
    [SerializeField] TMP_Text timerText;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            minutes = ((int)(timeRemaining / 60));
            timerText.text = "Time to Live: " + minutes + ":" + ((int)(timeRemaining - (minutes * 60)));
        }
        else
        {

        }
    }

    
}
