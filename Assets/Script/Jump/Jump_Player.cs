using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Player : MonoBehaviour
{
    /* // Start is called before the first frame update
     public float MoveSpeed;
     public float JumpPower;
     private Rigidbody rigid;
     public bool JumpEnabled;

     void Start()
     {

         rigid = GetComponent<Rigidbody>();
         JumpEnabled = false; // 점프 못해
     }
     void FixedUpdate()
     {
         Move();

         Jump();
     }
     void Move()
     {
         float h = Input.GetAxis("Horizontal");
         float v = Input.GetAxis("Vertical");

         transform.Translate((new Vector3(h, 0, 0) * MoveSpeed) * Time.deltaTime);
         //Debug.Log("무브");
     }

     void Jump()
     {
         bool Jumphelp = Input.GetKeyDown(KeyCode.W);
         if (JumpEnabled&&Jumphelp) //점프 상태 아니야
         {
             //print("점프 가능 !");
           //  JumpEnabled = true;//이거땜에 2단점프되네
             rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse); //이게 점프잖아
             JumpEnabled = false;
             Debug.Log("점프 가능한 상태");
         }
     }
     private void OnCollisionStay(Collision collision)
     {

         if (collision.gameObject.CompareTag("Ground"))
         {
             JumpEnabled =true; //점프
             Debug.Log("그라운드에 닿음");
         }
         else
         {
             JumpEnabled = false;  //점프못해
         }
         /*
         if (collision.gameObject.CompareTag("Break_goosle"))
         {
             GameObject[] break_walls = GameObject.FindGameObjectsWithTag("Break_wall");
             for (int i = 0; i < break_walls.Length; i++)
                 Destroy(break_walls[i]);
         }

         if (collision.gameObject.CompareTag("Dagger")) // 그라운드 태그에 닿으면
         {
             transform.position=new Vector3(-2, -5, 436);
         }
     }

     */

    // Start is called before the first frame update
    public float MoveSpeed;
    Rigidbody rigid;
    float jumpForce;
    public int jumpcount = 2;
    public bool isGrounded = true;
    public GameObject TrueScene;
    public GameObject TimeWatch;

    void Start()
    {

        rigid = GetComponent<Rigidbody>();
        MoveSpeed = 5f;
        isGrounded = true;
        jumpForce = 10f;
    }
    void FixedUpdate()
    {
        Move();

        Jump();
    }
    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate((new Vector3(h, 0, 0) * MoveSpeed) * Time.deltaTime);
        //Debug.Log("무브");
    }



    private void OnCollisionEnter(Collision col)

    {

        if (col.gameObject.tag == "Ground")
            jumpcount = 2;
    }


    void Jump()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.W) && jumpcount > 0)
        {
            rigid.velocity = Vector3.zero;
            Vector3 jumpVelocity = new Vector3(0, jumpForce);

            rigid.AddForce(jumpVelocity, ForceMode.Impulse);
            Debug.Log("점프카운트");
            jumpcount--;
        }


    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Dagger")) // 그라운드 태그에 닿으면
        {
            transform.position = new Vector3(-2, -5, 436);
        }

        if (collision.gameObject.CompareTag("End"))
        {
            TrueScene.SetActive(true);
            TimeWatch.SetActive(false);
            Debug.Log("오케이");


        }
    }
}