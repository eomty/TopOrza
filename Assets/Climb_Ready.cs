using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb_Ready : MonoBehaviour
{
    public GameObject PlayerCollider;
    public GameObject ReadyButton;
    public GameObject HpBar;
    
    void Start()
    {
        PlayerCollider.SetActive(true);
        HpBar.SetActive(false);
        ReadyButton.SetActive(true);
    }

    // Update is called once per frame
    public void ReadyGo()
    {
        PlayerCollider.SetActive(false);
        ReadyButton.SetActive(false);
        HpBar.SetActive(true);
    }
}
