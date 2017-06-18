using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/*
 * It`s for detecting collision between player and obstacle
 * if player touche obstacle will be game over and scene 
 * will be change for this on what is showing score etc.
*/

public class zmiana_loser : MonoBehaviour

{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "przeszkoda")
        {
           
            {
                SceneManager.LoadScene("wynik");
            }

        }
    }
}
