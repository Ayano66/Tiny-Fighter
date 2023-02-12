using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanceGenerate : MonoBehaviour
{
    float timer = 0f;
    public GameObject chance;
    public bool JunbiOk = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JunbiOk == true)
        {
            timer += Time.deltaTime;

            if (timer > 10f)
            {
                
                float posX = Random.Range(-98f, -61f);
                float posZ = Random.Range(56f, 80f);

                Instantiate(chance, new Vector3(posX, 8, posZ), this.transform.rotation);

                timer = 0f;
            }
        }
       
        

     
    }
    public void Set()
    {
        JunbiOk = true;
    }

}


