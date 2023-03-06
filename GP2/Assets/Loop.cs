using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
     int animationState = 0;
    
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
         animator = GetComponent<Animator>();
         animator.SetTrigger("Reset");
         animationState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (animationState == 0)
        {
             StartCoroutine(Reset());

        }

        if (animationState == 1)
        {
            StartCoroutine(Reset());
        }
    }


     IEnumerator Reset()
    {
        if(animationState == 0)
        {
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Reset2");
        animationState = 1;
        }

        if(animationState == 1)
        {
        yield return new WaitForSeconds(3f);
        animator.SetTrigger("Reset");
        animationState = 0;
        }


    }
}
