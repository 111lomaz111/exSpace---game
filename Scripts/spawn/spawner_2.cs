using UnityEngine;
using System.Collections;

public class spawner_2 : MonoBehaviour
{

    public GameObject[] spawnObject;
    private float sT;
    public float[] czas;
    private float sX;
    private float sX2;
    public float[] miejsce_x;
    //current time
    private float time;
    //czas do respa obj
    private float spawnTime;
    public float dodanie_czasu;
    public acc_automuve acc_automuve;

    void Start()
    {
        SetRandomTime();
        SetRandomPosition();
        time = Random.Range(0, czas.Length);
    }

    void FixedUpdate()
    {
       spawnTime = sT;
        //Counts up
        time += Time.deltaTime + dodanie_czasu;
        if(acc_automuve.Ready <= 0.01)
        {
            dodanie_czasu += 0.0025F;
        }

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
            SetRandomPosition();
        }
    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0; //Change this line
        int obiekt1 = Random.Range(0, spawnObject.Length);
        int obiekt2 = Random.Range(0, spawnObject.Length);
        float Y = gameObject.transform.position.y;
        Instantiate(spawnObject[obiekt1], new Vector3(sX, Y, 0), spawnObject[obiekt1].transform.rotation);
        Instantiate(spawnObject[obiekt2], new Vector3(sX2, Y, 0), spawnObject[obiekt2].transform.rotation);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        //spawnTime = Random.Range(minTime,maxTime);
        sT = czas[Random.Range(0, czas.Length)];

    }

    void SetRandomPosition()
    {
        sX = miejsce_x[Random.Range(0, miejsce_x.Length)];
        sX2 = miejsce_x[Random.Range(0, miejsce_x.Length)];
    }

    /*
    void OnGUI()
    {
        GUILayout.Label(time.ToString());
    }
*/

}

