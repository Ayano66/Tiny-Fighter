using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class asobikataButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HowtoPlayClicked()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("HowtoPlayScene");
        
    }

    public void ResultToHome()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("StartScene");
        
    }
}
