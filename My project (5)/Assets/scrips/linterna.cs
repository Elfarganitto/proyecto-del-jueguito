using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public Light luzLinterna;
    public bool activLight;
    public bool linternaEnMano;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && linternaEnMano == true)
        {
            activLight = !activLight;

            if(activLight == true)
            {
                luzLinterna.enabled = true;
            }

            if(activLight == false)
            {
                luzLinterna.enabled = false;
            }
        }
    }
}
