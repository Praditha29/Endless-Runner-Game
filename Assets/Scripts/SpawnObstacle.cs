using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject obstacle; //contains the object we want to spawn

    //to spawn our obstacle within the range of x and y axis
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    public float timeBetweenSpawn; //how much time till the next obstacle appears
    private float spawnTime;
  

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX,maxX); //to spawn object in different position everytime
        float randomY = Random.Range(minY,maxY); 

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
