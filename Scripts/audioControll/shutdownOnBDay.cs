using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class shutdownOnBDay : MonoBehaviour {

    public void OnLevelWasLoaded(int level)
    {
        if (level == 6)
        {
            gameObject.SetActive(false);
        }
        else gameObject.SetActive(true);
    }
}
