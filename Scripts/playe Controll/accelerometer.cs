using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour {

    public GameObject player;
    public float slow;

    // Update is called once per frame

    void Start()
    {
        slow = (PlayerPrefs.GetFloat("sensitivity"))/100;
    }


    void Update () {
        player.transform.Translate(Input.acceleration.x*slow, 0, 0);
    }
}
