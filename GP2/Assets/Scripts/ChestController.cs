using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public GameObject winCanvas;
    Animator animator;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
         animator = GetComponent<Animator>();
    }



        void OnTriggerEnter(Collider other)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("Play");
            winCanvas.SetActive(true);
            Debug.Log("win!");
            StartCoroutine(Win());
        }
    }


      IEnumerator Win()
    {
        
        yield return new WaitForSeconds(time);
         Time.timeScale = 0f;
        
    
    }
}
