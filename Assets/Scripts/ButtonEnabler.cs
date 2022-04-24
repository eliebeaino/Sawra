using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEnabler : MonoBehaviour
{
    [SerializeField] Button button;

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PeopleCounter>().counterFlag >= 25 && button.name == "Green")
        {
            button.interactable = true;
            Destroy(gameObject);
        }
        if (FindObjectOfType<PeopleCounter>().counterGreen >= 50 && button.name == "Red")
        {
            button.interactable = true;
            Destroy(gameObject);
        }

    }
}
