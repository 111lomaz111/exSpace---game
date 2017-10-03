using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script is checking memory for value in what is
 * saved information what style is prefered by user to 
 * controll ship and it`s turning it on.
 * Default it`s taking first version(taping on screen)
 */

public class check_mv_value : MonoBehaviour {
    public GameObject movement_v1, movement_v2, movement_v3;

    void Start()
    {
        string value = PlayerPrefs.GetString("movement", "");
        print("wybrano" + value + "...");
        if (value == "movement_v1")
        {
            movement_v1.SetActive(true);
            movement_v2.SetActive(false);
            movement_v3.SetActive(false);

        }
        else if (value == "movement_v2")
        {
            movement_v1.SetActive(false);
            movement_v2.SetActive(true);
            movement_v3.SetActive(false);
        }
        else if (value == "movement_v3")
        {
            movement_v1.SetActive(false);
            movement_v2.SetActive(false);
            movement_v3.SetActive(true);
        }
        else
        {
            movement_v1.SetActive(true);
            movement_v2.SetActive(false);
            movement_v3.SetActive(false);
        }
    }

}
