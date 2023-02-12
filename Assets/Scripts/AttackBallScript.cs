using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBallScript : MonoBehaviour
{
    float speed = 30.0f;
    float kesu = 0.3f;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * speed * Time.deltaTime;
        


       
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject, 0.1f);

            
        }
    }
}
