using UnityEngine;
using System.Collections;

/* 
 * It`s for control player ship with pc keyboard
 * very usefull in developing.
*/
public class poruszanie_pc : MonoBehaviour

{
    public bool ruchl = true;
    public bool ruchp = true;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) && ruchl)
        {
            //skoka.GetComponent<AudioSource>().Play();
            transform.Translate(-1.15F, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) && ruchp)
        {
            //skoka.GetComponent<AudioSource>().Play();
            transform.Translate(1.15F, 0, 0);
        }   
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "lewa")
        {
            ruchl = false;
            ruchp = true;
        }

        if (collision.gameObject.tag == "oba")
        {
            ruchl = true;
            ruchp = true;
        }

        if (collision.gameObject.tag == "prawa")
        {
            ruchp = false;
            ruchl = true;
        }
    }
}