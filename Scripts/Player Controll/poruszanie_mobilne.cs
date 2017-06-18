using UnityEngine;
using System.Collections;

/*
 *  This script is using for control player ship 
 *  by clicking on buttons which are screen.
 *  If u will touch the right side of screen u will call out 
 *  void ruch_prawo() similary for left side of screen. 
*/

public class poruszanie_mobilne : MonoBehaviour
{
    public bool ruchlewa;
    public bool ruchprawa;
    public GameObject bohater;
    public poruszanie_pc poruszanie_pc;

    public void Update()
    {
		ruchlewa = poruszanie_pc.ruchl;
		ruchprawa = poruszanie_pc.ruchp;
    }

    public void ruch_lewo()
    {
		if (ruchlewa)
        {
            //skoka.GetComponent<AudioSource>().Play();
            bohater.transform.Translate(-1.15F, 0, 0);
        }
    }

    public void ruch_prawo()
    {
		if (ruchprawa)
        {
            //skoka.GetComponent<AudioSource>().Play();
            bohater.transform.Translate(1.15F, 0, 0);
        }
    }
}
