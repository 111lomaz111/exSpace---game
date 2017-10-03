using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class shutdown_onBDay : MonoBehaviour {

    public GameObject audio;

    void Start()
    {
        int sceneindex = SceneManager.GetActiveScene().buildIndex;

        if (sceneindex == 5)
        {
            audio.SetActive(false);
        }
        else audio.SetActive(true);
    }
}
