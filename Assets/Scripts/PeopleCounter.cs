using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeopleCounter : MonoBehaviour
{
    public int counterRed;
    public int counterGreen;
    public int counterFlag;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Red") counterRed++;
        else if (collision.tag == "Green") counterGreen++;
        else if (collision.tag == "Flag") counterFlag++;
    } 

}
