using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public FloatingJoystick idou;
    public float speed;
    Animator ani;
    public GameObject mon;
    public GameObject MapMon;
    public GameObject kishimi;

    Quaternion qqq;
    Quaternion rot;

    public Image hpimage;
    float maxHP = 15;
    public float currentHP = 15;

    public bool Item_1 = false;
    public bool Item_2 = false;
    public bool Item_3 = false;

    public Transform hpGreen;
    public Transform hpRed;

    AudioSource audioSource;
    public AudioClip itemsound;
    public AudioClip damagesound;

    LastEnemySensor lescs;
    LastEnemyScript lecs;

    public Transform LastEnemySensor;
    public Transform LastEnemy;

    float timer = 0f;

    public Image enehpGreen;
    public Image enehpRed;

    public GameObject finalcol;
    ChanceGenerate ccs;
    public Transform chancegenerate;

    public GameObject senjou;

    public GameObject hoshi1;
    public GameObject hoshi2;
    public GameObject hoshi3;












    // Start is called before the first frame update
    void Start()
    {
        ani = this.gameObject.GetComponent<Animator>();
        enehpGreen.gameObject.SetActive(false);
        enehpRed.gameObject.SetActive(false);
        audioSource = this.gameObject.GetComponent<AudioSource>();
        lescs = LastEnemySensor.GetComponent<LastEnemySensor>();
        lecs = LastEnemy.GetComponent<LastEnemyScript>();
        ccs = chancegenerate.GetComponent<ChanceGenerate>();
        hoshi1.gameObject.SetActive(false);
        hoshi2.gameObject.SetActive(false);
        hoshi3.gameObject.SetActive(false);

    }
        

    

    // Update is called once per frame
    void Update()
    {
        Move();

        OpenGate();







    }


    void Move()
    {
        float dx = idou.Horizontal;
        float dy = idou.Vertical;

        float rad = Mathf.Atan2(dx - 0, dy - 0);
        float deg = rad * Mathf.Rad2Deg;

        this.transform.rotation = Quaternion.Euler(0, rot.eulerAngles.y + deg, 0);

        if (deg != 0)
        {
            ani.SetBool("run", true);
            this.transform.position += this.transform.forward * speed * Time.deltaTime;
            qqq = gameObject.transform.rotation;

        }
        else
        {
            ani.SetBool("run", false);

            this.transform.rotation = Quaternion.Euler(0, qqq.eulerAngles.y, 0);
            rot = gameObject.transform.rotation;
        }
    }
    //アイテムゲットを判定
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item_1")
        {
            Debug.Log("Get1!!");
            Destroy(other.gameObject);
            Item_1 = true;
            audioSource.clip = itemsound;
            audioSource.Play();
            hoshi1.gameObject.SetActive(true);

        }
    

        if (other.gameObject.tag == "Item_2")
        {
            Debug.Log("Get2!!");
            Destroy(other.gameObject);
            Item_2 = true;
            audioSource.clip = itemsound;
            audioSource.Play();
            hoshi2.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Item_3")
        {
            Debug.Log("Get3!!");
            Destroy(other.gameObject);
            Item_3 = true;
            audioSource.clip = itemsound;
            audioSource.Play();
            hoshi3.gameObject.SetActive(true);
        }

        if (other.gameObject.tag == "Chance")
        {
            lecs.SlowSpeed();
            lecs.ChanceSet();

            Debug.Log("Chance!!");
        }

        if (other.gameObject.tag == "Heart")
        {
            currentHP += 7;
            hpimage.fillAmount = currentHP / maxHP;
        }
    }





    //アイテムを全て集めたら門を開く
        public void OpenGate()
    {
        if (Item_1 == true && Item_2 == true && Item_3 == true)
        {
            Destroy(mon);
            Destroy(MapMon);
          
        }
        
    }

    
    void OnCollisionEnter(Collision col)
    {
        //敵との衝突を判定
        if (col.gameObject.tag == "Enemy")
        {
            this.gameObject.GetComponent<AudioSource>().clip = damagesound;
            this.gameObject.GetComponent<AudioSource>().Play();

            

            if (currentHP <= 15)
            {
                if (currentHP == 1)
                {
                    SceneManager.LoadScene("GameOverScene");
                }
                else
                {
                    currentHP -= 1;
                    hpimage.fillAmount = currentHP / maxHP;

                }


            }


        }

        if (col.gameObject.tag == "LastEnemy")
        {

            this.gameObject.GetComponent<AudioSource>().clip = damagesound;
            this.gameObject.GetComponent<AudioSource>().Play();

            if (currentHP <= 15)
            {
                if (currentHP <= 1)
                {
                    SceneManager.LoadScene("GameOverScene");
                }
                else
                {
                    currentHP -= 2;
                    hpimage.fillAmount = currentHP / maxHP;

                }
            }

        }
        //戦場のフィールドに入ったことを判定
        //敵のHPバーなどを表示する
        if (col.gameObject.tag == "Senjou")
        {
            enehpGreen.gameObject.SetActive(true);
            enehpRed.gameObject.SetActive(true);
            finalcol.GetComponent<Collider>().isTrigger = false;
            ccs.Set();
            currentHP = 15;
            hpimage.fillAmount = currentHP / maxHP;

            senjou.gameObject.tag = "Untagged";

        }
    }







}