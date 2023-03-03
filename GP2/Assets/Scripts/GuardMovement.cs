using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardMovement : MonoBehaviour
{
    public NavMeshAgent guard;
    public GameObject player;
    public int detectionRange = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= detectionRange){
        guard.SetDestination(player.transform.position);
        }
    }

        void OnCollisionEnter(Collision other)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerHit>().KillPlayer();
        }
    }
}
