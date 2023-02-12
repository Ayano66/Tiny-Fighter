using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class posiOnMap : MonoBehaviour
{
    public Transform targetPlayer;
    public Vector3 offset;

    void Update()
    {
        offset = new Vector3(195, 0, 0);
        this.transform.position = targetPlayer.position + offset;
    }
}