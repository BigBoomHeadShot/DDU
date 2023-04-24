using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialScript : MonoBehaviour
{
    [SerializeField] GameObject tutorial;
    [SerializeField] GameObject objective;
    [SerializeField] TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Menu()
    {
        tutorial.SetActive(!tutorial.activeSelf);
        objective.SetActive(!objective.activeSelf);

        if (text.text == "Objectives")
        {
            text.text = "Tutorial";
        }
        else
        {
            text.text = "Objectives";
        }

    }
}
