using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Test_Player : MonoBehaviour
{

    public float Speed = 20f;
    public float rotSpeed = 2.0f;
    public Camera fpsCam;
    public GameObject TrueScene;
    public GameObject TimeWatch;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RotCtrl();

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
    }
    void RotCtrl()
    { //마우스 회전 시점이동 함수
        float rotX = Input.GetAxis("Mouse Y") * rotSpeed;
        float rotY = Input.GetAxis("Mouse X") * rotSpeed;

        this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);
        fpsCam.transform.localRotation *= Quaternion.Euler(-rotX, 0, 0);
    }
    private void OnCollisionStay(Collision collision)
    {



        if (collision.gameObject.CompareTag("Break_goosle"))
        {
            GameObject[] break_walls = GameObject.FindGameObjectsWithTag("Break_wall");
            for (int i = 0; i < break_walls.Length; i++)
                Destroy(break_walls[i]);
        }

        if (collision.gameObject.CompareTag("End"))
        {
            TrueScene.SetActive(true);
            Destroy(TimeWatch);
            Debug.Log("오케이");
        }

    }




}
