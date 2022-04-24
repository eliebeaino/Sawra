using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSelecter : MonoBehaviour
{
    Text text;
    Button thisButton;
    [SerializeField] GameTimer gameTimer;
    [SerializeField] float buttonOffTimer = 0.5f;
    void Start()
    {
        text = GetComponentInChildren<Text>();
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(TaskListener);
        if (thisButton.name == "Red" || thisButton.name == "Green")
        {
            thisButton.interactable = false;
        }
    }
    void TaskListener()
    {
        StartCoroutine(ButtonTimer());
    }

    IEnumerator ButtonTimer()
    {
        thisButton.interactable = false;
        yield return new WaitForSeconds(buttonOffTimer);
        thisButton.interactable = true;
    }
    void Update()
    {
        if (gameTimer.EndGame())
        {
            thisButton.enabled = false;
        }

        if (thisButton.name == "Red")
        {
            //if (FindObjectOfType<PeopleCounter>().counterGreen >= 50) thisButton.interactable = true;
            text.text = FindObjectOfType<PeopleCounter>().counterRed.ToString();
        }
        if (thisButton.name == "Green")
        {
            //if (FindObjectOfType<PeopleCounter>().counterFlag >= 25) thisButton.interactable = true;

            text.text = FindObjectOfType<PeopleCounter>().counterGreen.ToString();
        }
        if (thisButton.name == "Flag")
        {
            text.text = FindObjectOfType<PeopleCounter>().counterFlag.ToString();
        }



    }
}
