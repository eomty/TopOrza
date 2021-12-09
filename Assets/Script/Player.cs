using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    int layermask = 1 << 9;

    private Rigidbody rigid;

  public int JumpPower = 1;
   public int MoveSpeed = 1;
    public int RotateSpeed = 1;
    public bool IsJumping; //점프상태 중이니?
    
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
        //IsJumping = false;
    }
	
	// Update is called once per frame
	void Update () {
        //mask = ~mask;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit = new RaycastHit();                       
Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit,layermask))
            {
                Debug.Log("클릭 되엇씁니다.");
                            }
            }
        Move();
        Jump();
    }
    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate((new Vector3(h, 0, v) * MoveSpeed) * Time.deltaTime);
        //Debug.Log("무브");
    }

    void Jump()
    {
        if (!IsJumping) //점프 상태 아니야
        {
            //print("점프 가능 !");
            IsJumping = true;// 점프상태중이니 점프못해 다시
            rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse);
            Debug.Log("점프 가능한 상태");
           

        }
    }

    

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Teleport"))
        {
            gameObject.transform.position = new Vector3(10, 10, 10);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            IsJumping = false; //점프 할수있는 상태
            Debug.Log("그라운드에 닿음");
            
        }
    }
}
