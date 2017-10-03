using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundOnClick : MonoBehaviour
{
    public AudioClip[] sounds;

    void Start()
    {
        sounds = new AudioClip[]
        {
            (AudioClip)Resources.Load("Sounds/click"),
            (AudioClip)Resources.Load("Sounds/07Extream")
        };
    }

    public void click(GameObject obj)
    {  
        AudioSource soundSource = obj.GetComponent<AudioSource>();
        soundSource.clip = sounds[0];
        soundSource.Play();     
    }
}
