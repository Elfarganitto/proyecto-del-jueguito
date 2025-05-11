using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaPick : MonoBehaviour
{
    public GameObject Linterna;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Linterna.SetActive(true);
            Linterna.GetComponent<Linterna>().linternaEnMano = true;
            Destroy(gameObject);
        }
    }
}
