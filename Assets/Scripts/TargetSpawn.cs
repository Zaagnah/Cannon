using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] DownObj;
    

    private void SpawnTarget()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        int randomDrop = Random.Range(0, DownObj.Length);

        Instantiate(DownObj[randomDrop], spawnPoints[randomIndex].position, Quaternion.identity);

    }

    // Update is called once per frame
    void Start()
    {
        
            SpawnTarget();
            

    }
}
