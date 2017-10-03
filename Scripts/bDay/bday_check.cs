using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class bday_check : MonoBehaviour
{
    public string theDate;
    void Start()
    {
        theDate = System.DateTime.Now.ToString("MM/dd");
        if (theDate == "10/30")
        {
            SceneManager.LoadScene("happybday");
        }    
        else SceneManager.LoadScene("wynik");
    }
}