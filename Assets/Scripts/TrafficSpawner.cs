using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSpawner : MonoBehaviour
{
    [SerializeField] float mintimeBetweenSpawns = .5f;
    [SerializeField] float maxtimeBetweenSpawns = 3f;
    float spawnTimer;
    [SerializeField] GameObject[] spawnType;
    [SerializeField] GameObject[] Spawner;
    int chooseSpawnTemp;
    int chooseSpawn;

    [SerializeField] bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            spawnTimer = Random.Range(mintimeBetweenSpawns, maxtimeBetweenSpawns);
            yield return new WaitForSeconds(spawnTimer);
            SpawnTraffic();
        }
    }

    void SpawnTraffic()
    {
        int chooseType = Random.Range(0, spawnType.Length);
        var transformPicked = ChooseSpawnPosition().transform.position;
        GameObject newSpawn = Instantiate(spawnType[chooseType], transformPicked, Quaternion.identity);
    }

    private GameObject ChooseSpawnPosition()
    {
        chooseSpawnTemp = chooseSpawn;
        while(chooseSpawnTemp == chooseSpawn)
        {
            chooseSpawn = Random.Range(0, Spawner.Length);
        }
        GameObject spawnPicked = Spawner[chooseSpawn];
        return spawnPicked;
    }

    public void StopSpawn()
    {
        spawn = false;
    }
    public void ResumeSpawn()
    {
        spawn = true;
    }
}
