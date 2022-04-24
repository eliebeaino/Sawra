using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficCounter : MonoBehaviour
{
    public int counter;
    public int maxCounter = 5;
    [SerializeField] TrafficSpawner trafficSpawner;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        counter++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        counter--;
    }

    private void Update()
    {
        if (counter >= maxCounter)
        {
            trafficSpawner.StopSpawn();
        }
    }
}
