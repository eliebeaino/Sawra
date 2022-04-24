using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] spawnType;
    [SerializeField] GameObject[] Spawner;
    [SerializeField] AudioClip[] SpawnSFX;
    [SerializeField] float volumeControlPeople = 1f;


    void SpawmSFX()
    {
        int i = Random.Range(0, SpawnSFX.Length);
        AudioSource.PlayClipAtPoint(SpawnSFX[i], Camera.main.transform.position, volumeControlPeople);
    }

    public void SpawnRed()
    {
        int  chooseSpawn = Random.Range(0, Spawner.Length);
        GameObject newSpawn = Instantiate(spawnType[0], Spawner[chooseSpawn].transform.position, Quaternion.identity);
        chooseSpawn = Random.Range(0, Spawner.Length);
        newSpawn = Instantiate(spawnType[0], Spawner[chooseSpawn].transform.position, Quaternion.identity);
        chooseSpawn = Random.Range(0, Spawner.Length);
        newSpawn = Instantiate(spawnType[0], Spawner[chooseSpawn].transform.position, Quaternion.identity);
        SpawmSFX();
    }
    public void SpawnGreen()
    {
        int chooseSpawn = Random.Range(0, Spawner.Length);
        GameObject newSpawn = Instantiate(spawnType[1], Spawner[chooseSpawn].transform.position, Quaternion.identity);
        chooseSpawn = Random.Range(0, Spawner.Length);
        newSpawn = Instantiate(spawnType[1], Spawner[chooseSpawn].transform.position, Quaternion.identity);
        SpawmSFX();
    }
    public void SpawnFlag()
    {
        int chooseSpawn = Random.Range(0, Spawner.Length);
        GameObject newSpawn = Instantiate(spawnType[2], Spawner[chooseSpawn].transform.position, Quaternion.identity);
        SpawmSFX();
    }
}
