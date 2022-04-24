using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAgainButton : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] Text endText;
    [SerializeField] PeopleCounter peopleCounter;
    // Start is called before the first frame update
    void Start()
    {
        thisButton.enabled = false;
    }

    public void EnableButton()
    {
        int totalCount = peopleCounter.counterFlag + peopleCounter.counterGreen + peopleCounter.counterRed;
        thisButton.enabled = true;
        endText.text = "You a gathered a" + 
                        "\r\nTotal of:"  + 
                        "\r\n" + 
                        "\r\n" + totalCount.ToString() + " people." +
                        "\r\n" + 
                        "\r\nPlay Again";
    }


}
