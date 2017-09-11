using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject player;
    public GameObject wall;

    float minSpawnPositionX;
    float maxSpawnPositionX;
    float minSpawnPosY;
    float maxSpawnPosY;

    float objectTimer = 0f;
    float objectSpawnInterval = 10f;

    // Update is called once per frame
    void Update() {

        // this is for the wall tho 
        minSpawnPositionX = player.transform.position.x + 38f;
        maxSpawnPositionX = minSpawnPositionX + 22f;

        minSpawnPosY = 7f;
        maxSpawnPosY = -7f;

        if (objectTimer < objectSpawnInterval)
        {
            objectTimer += Time.deltaTime;
        }
        else {
            objectTimer = 0;
            SpawnObject();
        }

    }

    void SpawnObject()
    {

       Vector3 spawnPosition = new Vector3 (Random.Range(minSpawnPositionX, maxSpawnPositionX), Random.Range(minSpawnPosY, maxSpawnPosY), 1);
        Instantiate(wall, spawnPosition, Quaternion.Euler(0, 180, 0));

        Debug.Log("blaaaa");
    }

}
