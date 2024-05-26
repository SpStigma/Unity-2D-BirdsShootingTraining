using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> prefabsbirds;

    public Transform spawnRigthX;
    public Transform spawnRigthY;

    public Transform spawnLeftY;
    public Transform spawnLeftX;

    [Space(20)]
    public float timeSpawner = 2f;
    private float counterDecrement;
    private float timeLastReduction;
    private float minReductionSpawner = 0.25f;

    void Start()
    {
        counterDecrement = timeSpawner;
        timeLastReduction = 0f;
    }

    void Update()
    {
        timeLastReduction += Time.deltaTime;
        counterDecrement -= Time.deltaTime;

        if(counterDecrement <= 0)
        {
            GameObject newBird =  Instantiate(prefabsbirds[Random.Range(0, prefabsbirds.Count)], SelectSpawnPoint(), Quaternion.identity);
            if (newBird.transform.position.x > transform.position.x)
            {
                // Si l'oiseau est généré du côté droit, basculez son sprite horizontalement
                newBird.GetComponent<SpriteRenderer>().flipX = false;
            }
            counterDecrement = timeSpawner;
        }

        ReduceSpawnTime();
    }

    public void ReduceSpawnTime()
    {
        if(timeLastReduction >= 5f)
        {
            timeSpawner *= .9f;
            if (timeSpawner < minReductionSpawner)
            {
                timeSpawner = minReductionSpawner;
            }
            timeLastReduction = 0f;
        }
    }

    public Vector3 SelectSpawnPoint()
    {
        Vector3 spawnPoint = Vector3.zero;
        bool RightSide = Random.Range(0f, 1f) > .5f;

        if (RightSide)
        {
            spawnPoint.x = spawnRigthX.position.x;
            spawnPoint.y = Random.Range(spawnRigthX.position.y, spawnRigthY.position.y);
        }
        else
        {
            spawnPoint.x = spawnLeftX.position.x;
            spawnPoint.y = Random.Range(spawnLeftX.position.y, spawnLeftY.position.y);
        }
        return spawnPoint;
    }
}
