using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript_Jump : MonoBehaviour
{
    public GameObject playerCollider;
    public GameObject TimeText;
    public GameObject ReadyButton;


    public GameObject Shu; // 표창 프리팹을 빈 오브젝트 넣으시오.
    public GameObject Clo; // 구름 프리팹(움직이는 것들)을 빈 오브젝트에 넣으시오.

    void Start()
    {
        TimeText.SetActive(false);
        Shu.SetActive(false);
        Clo.SetActive(false);
        playerCollider.SetActive(true);
    }

    public void ReadyGo()
    {
        Debug.Log("시작!");
        TimeText.SetActive(true);
        Shu.SetActive(true);
        Clo.SetActive(true);
        playerCollider.SetActive(false);

        ReadyButton.SetActive(false);
    }
}
