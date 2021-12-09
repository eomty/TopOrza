using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public Text timecount;
   public float TimeCost;
    public int sec;
    public int min;
    


    // Update is called once per frame
    void Update()
    {
        TimeCost += Time.deltaTime;
        if(TimeCost >= 1)
        {
            sec++;
            TimeCost -= 1;
        }
        if(sec >= 60)
        {
            min++;
            sec -= 60;
        }
       
       timecount.text= string.Format("{00:00}.{1:00}{2:.00}",min,sec,TimeCost);
       // timecount.text = string.Format("{0:F2}", TimeCost);
    }
    
}
