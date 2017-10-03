using UnityEngine;
using System.Collections;

/*
 *  OK this script is used to control player 
 *  object (ship) by sliding finger on screen.  
*/

public class player_control_v2 : MonoBehaviour
{
    public bool ruchl;
    public bool ruchp;
    public bool possibility;
    public GameObject bohater;
    public poruszanie_pc poruszanie_pc;

    void Start()
    {
        possibility = true;
    }

    void Update()
    {
        ruchl = poruszanie_pc.ruchl;
        ruchp = poruszanie_pc.ruchp;
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Moved && possibility) // && possibility
            {
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

                if (touchDeltaPosition.x > 0 && ruchp)
                {
                    bohater.transform.Translate(1.15F, 0, 0);
                    possibility = false;
                }
                if (touchDeltaPosition.x < 0 && ruchl)
                {
                    bohater.transform.Translate(-1.15F, 0, 0);
                    possibility = false;
                }
            }
            else if ((Input.GetTouch(i).phase == TouchPhase.Ended || Input.GetTouch(i).phase == TouchPhase.Canceled) && possibility == false)
            {
                possibility = true;
            }
        }
    }
}
