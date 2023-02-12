using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class timerScript : MonoBehaviour
{
    public Text timerText;
    float timer = 300f;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            int minute = (int)timer / 60;
            int second = (int)timer % 60;
            string minText, secText;

            minText = minute.ToString();
            secText = second.ToString();

            timerText.text = minText + ":" + secText;
        }

        else
        {
            SceneManager.LoadScene("GameOverScene");
        }
        
        

        
    }
}
