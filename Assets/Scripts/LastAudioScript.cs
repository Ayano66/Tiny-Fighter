using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastAudioScript : MonoBehaviour
{
    public Transform Player;
    PlayerScript plScript;
    public Transform positionCam;
    public Text timer;
    // Start is called before the first frame update
    void Start()
    {
        plScript = Player.GetComponent<PlayerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.GetComponent<AudioSource>().Play();

            positionCam.gameObject.SetActive(false);
            timer.gameObject.SetActive(false);

        }

        plScript.currentHP = 15;
    }
}
