using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int playerHealth;
    public GameObject healthCanvas1;
    public GameObject healthCanvas2;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth >= 2) {
            healthCanvas1.SetActive(true);
        }
        else {
            healthCanvas1.SetActive(false);
        }

        if (playerHealth == 3) {
            healthCanvas2.SetActive(true);
        }
        else {
            healthCanvas2.SetActive(false);
        }

        if (playerHealth < 1){
            player.GetComponent<PlayerHit>().KillPlayer();
        }

        

    }

    public void TakeDamage(){
        playerHealth -= 1;
    }

    public void GainHealth(){
        playerHealth += 1;
    }


   
}
