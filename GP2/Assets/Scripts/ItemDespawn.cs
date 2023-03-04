using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawn : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter(Collider other)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "Player")
        {
            if(this.gameObject.tag == "shields"){
                Debug.Log("collected shield");
                player.GetComponent<PlayerHealth>().GainHealth();
            }
            
            gameObject.SetActive (false);

            
        }
    }
}
