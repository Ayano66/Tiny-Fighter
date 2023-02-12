using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void AttackButtonClicked()
    {
        Instantiate(Ball, this.transform.position, this.transform.rotation);
        this.gameObject.GetComponent<AudioSource>().Play();
    }


}

