using UnityEngine;
using System.Collections;

public class spawn_random : MonoBehaviour {

    //Spawn this object
    public GameObject[] spawnObject;

    public float maxTime;
    public float minTime;
    private float sT;
   //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {
        spawnTime = Mathf.Round(sT*10)/10;
    //Counts up
        time += Time.deltaTime;
        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }
    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 1.2F; //Change this line
        int objectIndex = Random.Range(0, spawnObject.Length);
        Instantiate(spawnObject[objectIndex], transform.position, spawnObject[objectIndex].transform.rotation);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {      
        //spawnTime = Random.Range(minTime,maxTime);
        sT = Random.Range(minTime, maxTime);
    }

    /*
    void OnGUI()
    {
        GUILayout.Label(spawnTime.ToString());
    }
    */

}

