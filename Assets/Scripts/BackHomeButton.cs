using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackHomeButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackHomeButtonClicked()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("StartScene");
    }
}
