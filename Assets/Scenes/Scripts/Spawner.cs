using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabsbirds;

    public Transform spawnRigthX;
    public Transform spawnRigthY;

    public Transform spawnLeftY;
    public Transform spawnLeftX;

    [Space(20)]
    public float timeSpawner = 2f;
    private float counterDecrement;

    void Start()
    {
        counterDecrement = timeSpawner;
    }

    void Update()
    {
        counterDecrement -= Time.deltaTime;
        if(counterDecrement <= 0)
        {
            GameObject newBird =  Instantiate(prefabsbirds, SelectSpawnPoint(), Quaternion.identity);
            if (newBird.transform.position.x > transform.position.x)
            {
                // Si l'oiseau est généré du côté droit, basculez son sprite horizontalement
                newBird.GetComponent<SpriteRenderer>().flipX = false;
            }
            counterDecrement = timeSpawner;
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
