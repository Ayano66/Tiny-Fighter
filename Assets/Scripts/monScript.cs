using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monScript : MonoBehaviour
{
    PlayerScript plScript;
    public Transform Player;
    public float speed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        plScript = Player.GetComponent<PlayerScript>();

        if (plScript.Item_1 == true && plScript.Item_2 == true && plScript.Item_3 == true)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
