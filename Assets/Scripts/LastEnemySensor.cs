using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastEnemySensor : MonoBehaviour
{
    public GameObject Lenemy;
    LastEnemyScript Lencs;

    // Start is called before the first frame update
    void Start()
    {
        Lencs = Lenemy.GetComponent<LastEnemyScript>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Lencs.tuiseki();
        }



    }



    /*void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            encs.haikai();
        }
    }*/
}
