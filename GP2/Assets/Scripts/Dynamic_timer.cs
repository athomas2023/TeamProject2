using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamic_timer : MonoBehaviour
{
    public float Time_amount;
    public Image mask;
    float timeLeft;
    float originalSize;
    // Start is called before the first frame update
    void Start()
    {
        originalSize = mask.rectTransform.rect.width;
        timeLeft = Time_amount;
    }


    void Update()
    {
            if (timeLeft > 0.9)
            {
                timeLeft -= Time.deltaTime;
                mask.fillAmount = timeLeft / Time_amount;
            }
            else {
                Time.timeScale = 0;
            }
    }

    
}
