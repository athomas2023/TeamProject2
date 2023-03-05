using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pit_fall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerHit controller = other.GetComponent<PlayerHit>();


        if (controller != null)
        {


            controller.KillPlayer();


        }
    }
}
