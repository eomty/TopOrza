using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Climb_Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpeed;
    public float MoveHelp;

    public Image hpbar;
    public float Hp;
    public GameObject TrueScene;
    public GameObject FalseScene;

    public object Hpbar { get; private set; }

    //public GameObject TimeWatch;


    void Start()
    {
        Hp = 15f;
        MoveSpeed = 4;
        MoveHelp = 0; //1이면 체력이 차도록 이동못함
    }
    void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        if (Hp >= 15f)
        {
            Hp = 15f;
        }
        if (Hp <= 0f)
        {
            Hp = 0f;

            FalseScene.SetActive(true);
           MoveHelp = 1;
          
        }

    }
    void Move()
    {
        if (MoveHelp <= 0) //무브헬프가 0이어야 이동가능
        {

            if (Hp != 0)
            {
                Hp -= Time.deltaTime;
                hpbar.fillAmount -= 1.0f / 15 * Time.deltaTime;

            }

            Debug.Log("소모중입니다.");
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            transform.Translate((new Vector3(h, v, 0) * MoveSpeed) * Time.deltaTime);
        }
        else
        {
            Debug.Log("회복중입니다.");
            Hp += 2 * Time.deltaTime;
            hpbar.fillAmount += 1.0f / 7.5f * Time.deltaTime;


            if (Hp >= 15f)
            {
                Debug.Log("제발 무브헬프0으로!! ");
                MoveHelp = 0;

            }

        }

        //Debug.Log("무브");
    }







    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Hill"))
        {
            Debug.Log("힐에 닿음"); //스피드1로 헬프1로
            //PlayerHPbar2();
            MoveHelp = 1;
            MoveSpeed = 4;
        }

        if (collision.gameObject.CompareTag("End"))
        {
            TrueScene.SetActive(true);
            //TimeWatch.SetActive(false);
            Debug.Log("오케이");
            MoveHelp = 1;
            
        }

        if (collision.gameObject.CompareTag("Rock"))
        {
            MoveSpeed = 3;
            gameObject.transform.position=new Vector3(8, -3, 436);
        }



        /*
        if (collision.gameObject.CompareTag("Break_goosle"))
        {
            GameObject[] break_walls = GameObject.FindGameObjectsWithTag("Break_wall");
            for (int i = 0; i < break_walls.Length; i++)
                Destroy(break_walls[i]);
        }
        */
    }
}