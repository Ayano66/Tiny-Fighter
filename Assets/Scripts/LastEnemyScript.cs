using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LastEnemyScript : MonoBehaviour
{
    public Transform Target;
    //public Transform random;
    NavMeshAgent agent;
    bool sensor;
    public float speed;

    public Image hpImage;
    float eneCurrentHP = 25f;
    float eneMaxHP = 25f;

    PlayerScript pscs;
    public Transform Player;

    public bool chance = false;

 
    
  

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 3.5f;
        pscs = Player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (sensor == false)
        {
            agent.destination = random.transform.position;
        }*/

        //センサー感知したら
        //追跡を作動させる
        if (sensor == true)
        {

            agent.destination = Target.transform.position;
            
            
        }
        //プレイヤーがチャンスアイテムを拾ったら
        //オブジェクトの動きを遅くする
        if (chance == false)
        {
            
            //難易度をだんだん上げるオプション
            if (eneCurrentHP <= 25f && eneCurrentHP >= 20f)
            {
                middleSpeed();


            }

            if (eneCurrentHP < 20f && eneCurrentHP >= 10f)
            {
                middleSpeed();


            }

            if (eneCurrentHP < 10f && eneCurrentHP > 1f)
            {
                highSpeed();

            }
        }
        



    }
    //たぶん使ってない関数
    public void ChanceSet()
    {
        chance = true;
    }


    //スピードの設定
    public void SlowSpeed()
    {
        agent.speed = 0.5f;
    }

    public void middleSpeed()
    {
        agent.speed = 4.0f;
    }
    public void highSpeed()
    {
        agent.speed = 5.5f;
    }
   


    //たぶん使ってない関数
    public void tuiseki()
    {
        sensor = true;
    }

    /*public void haikai()
    {
        sensor = false;
    }*/

    /*private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            

        }
    }*/

    //ダメージ判定
    void OnCollisionEnter(Collision col)
    {
        

        if (col.gameObject.tag == "Ball")
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            chance = false;

            if (eneCurrentHP <= 25f )
            { 
                
                eneCurrentHP -= 1f;
                hpImage.fillAmount = eneCurrentHP / eneMaxHP;
              
            }

            
            //シーン遷移
            if (eneCurrentHP == 1f)
            {
                
                 SceneManager.LoadScene("ResultScene");
                
            }


        }


    }




}

