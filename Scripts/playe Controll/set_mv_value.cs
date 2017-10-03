using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 
 * It`s definig what style of controlling ship is selected by user,
 * and saving this choice to memory.
 */ 

public class set_mv_value : MonoBehaviour {

    public Text show_actual_movement;
    string value;

    void Start()
    {
        //PlayerPrefs.SetString("movement", "");
        value = PlayerPrefs.GetString("movement", "");

        if (value == "movement_v1")
        {
            show_actual_movement.text = "TAPING";
            print("wczytano wczesniejesze ustawienie: movement_v1");

        }
        else if (value == "movement_v2")
        {
            show_actual_movement.text = "SLIDING";
            print("wczytano wczesniejesze ustawienie: movement_v2");
        }
        else if (value == "movement_v3")
        {
            show_actual_movement.text = "ACCELEROMETER";
            print("wczytano wczesniejesze ustawienie: movement_v3");
        }
        else
        {
            show_actual_movement.text = "Select steering style";
        }
    }

    public void setMovement()
    {
        value = PlayerPrefs.GetString("movement", "");

        if (value == "movement_v1")
        {
            PlayerPrefs.SetString("movement", "movement_v2");
            print("kliknieto i wybrano sterowanie movement_v2");
            show_actual_movement.text = "SLIDING";
            PlayerPrefs.Save();
        }
        else if (value == "movement_v2" || value == "")
        {
            PlayerPrefs.SetString("movement", "movement_v3");
            print("kliknieto i wybrano sterowanie movement_v3");
            show_actual_movement.text = "Accelerometer";
            PlayerPrefs.Save();
        }
        else if (value == "movement_v3" || value == "")
        {
            PlayerPrefs.SetString("movement", "movement_v1");
            print("kliknieto i wybrano sterowanie movement_v1");
            show_actual_movement.text = "TAPING";
            PlayerPrefs.Save();
        }
        else
        {
            PlayerPrefs.SetString("movement", "movement_v1");
            print("nie kliknieto i wybrano sterowanie movement_v1");
            PlayerPrefs.Save();
        }
        
    }
}
