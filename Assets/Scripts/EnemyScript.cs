using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    public Transform Target;
    public Transform random;
    NavMeshAgent agent;
    bool sensor;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (sensor == false)
        {
            agent.destination = random.transform.position;
        }
        if (sensor == true)
        {
            agent.destination = Target.transform.position;
        }
    }

    public void tuiseki()
    {
        sensor = true;
    }

    public void haikai()
    {
        sensor = false;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {

            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
