using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timecount;
    public float TimeCost;
    public GameObject falseFloor;

    


        void Update()
    {
        if (TimeCost <= 0)
        {
            falseFloor.SetActive(true);
        }
        else {
        TimeCost -= Time.deltaTime;
        timecount.text = string.Format("{0:F2}", TimeCost);
            
        }

    }
}
