using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomScript : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Warp());
    }

    private IEnumerator Warp()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(3f);

           
            float posX = Random.Range(-100f, 0f);
            float posZ = Random.Range(-55f, 30f);

            transform.position = new Vector3(posX, 0, posZ);
        }
    }
}