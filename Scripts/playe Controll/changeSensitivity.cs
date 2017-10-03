using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class changeSensitivity : MonoBehaviour {

    public Text value_text;
    public Slider value_float;

    void Start()
    {
        value_text.text = "Sensitivity " +  PlayerPrefs.GetFloat("sensitivity").ToString();
        value_float.value = PlayerPrefs.GetFloat("sensitivity");
    }


    public void OnValueChanged(float newValue)
    {
        value_text.text = "Sensitivity " + newValue.ToString();
        PlayerPrefs.SetFloat("sensitivity", newValue);
    }
}
