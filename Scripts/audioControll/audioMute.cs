using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class audioMute : MonoBehaviour {

    private bool mute;
    public Sprite audioON, audioOFF;
    public string value;
    public Button button;

    void Start () {
        value = PlayerPrefs.GetString("audio", "");
        if (value == "ON")
        {
            AudioListener.pause = false;
            mute = true;
            button.image.sprite = audioON;
        }
        if (value == "OFF")
        {
            AudioListener.pause = true;
            mute = false;
            button.image.sprite = audioOFF;
        }
        else
        {
            mute = false;
            button.image.sprite = audioON;
            PlayerPrefs.SetString("audio", "ON");
            PlayerPrefs.Save();
        }
    }

	
	public void change_state()
    {
        value = PlayerPrefs.GetString("audio", "");
        if (value == "OFF")
        {
            AudioListener.pause = false;
            mute = true;
            button.image.sprite = audioON;
            PlayerPrefs.SetString("audio", "ON");
            PlayerPrefs.Save();
        }
        if (value == "ON")
        {
            AudioListener.pause = true;
            mute = false;
            button.image.sprite = audioOFF;
            PlayerPrefs.SetString("audio", "OFF");
            PlayerPrefs.Save();
        }

	}
}
