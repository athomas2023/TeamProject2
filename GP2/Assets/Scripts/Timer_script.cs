using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer_script : MonoBehaviour


{

    public TextMeshProUGUI Timer_min;
    public TextMeshProUGUI Timer_sec;
    public TextMeshProUGUI Timer_min_WC;
    public TextMeshProUGUI Timer_sec_WC;

    public string sceneName;


    public float max_Time;
    public float current_Time;
    public float current_Min;
    // Start is called before the first frame update
    void Start()
    {
        
        Timer_min.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        current_Time += 1 * Time.deltaTime;
        Timer_sec.text = current_Time.ToString("0");
        Timer_min.text = current_Min.ToString();
        Timer_sec_WC.text = current_Time.ToString("0");
        Timer_min_WC.text = current_Min.ToString();

        if (current_Time >= 60.00)
        {
            current_Time = 0;
            current_Min = current_Min + 1;

        }


        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            SceneManager.LoadScene(sceneName);
        }

    }

    IEnumerator LoadScene()
    {

        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(sceneName);


    }




}

