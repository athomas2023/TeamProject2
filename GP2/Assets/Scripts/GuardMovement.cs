using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardMovement : MonoBehaviour
{
    public NavMeshAgent guard;
    public GameObject player;
    public int detectionRange = 5;
     public int timeInvincible = 3;
    private bool isActive;
    public AudioSource aggroSound;
    public AudioSource inactiveSound;
    private bool isAggro;
    
    // Start is called before the first frame update
    void Start()
    {
        isActive = true;
        isAggro = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive == true){
        if (Vector3.Distance(transform.position, player.transform.position) <= detectionRange){
        guard.SetDestination(player.transform.position);
            isAggro = true;
        }
        }


        if(Vector3.Distance(transform.position, player.transform.position) > detectionRange){
            isAggro = false;
        }

        if(isAggro == true){
            inactiveSound.enabled = false;
            aggroSound.enabled = true;
        }
        else if (isAggro == false){
            inactiveSound.enabled = true;
            aggroSound.enabled = false;
        }
    }

        void OnCollisionEnter(Collision other)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "Player")
        {
            if(isActive == true){
            player.GetComponent<PlayerHealth>().TakeDamage();
            StartCoroutine(Invincibility());
            }

        }
    }

    IEnumerator Invincibility()
{
        isActive = false;
        Debug.Log("not active");
        yield return new WaitForSeconds(timeInvincible);
        isActive = true;
        Debug.Log("active");
    
}
}
