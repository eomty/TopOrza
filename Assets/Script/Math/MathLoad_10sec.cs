using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MathLoad_10sec : MonoBehaviour
{
  
    public Image LoadGauge;
    public float LoadTime;
    public GameObject WrongAnswerImg;

    // Start is called before the first frame update
    void Start()
    {
        LoadTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (LoadTime != 10f)
        {
            LoadTime += Time.deltaTime;
            LoadGauge.fillAmount -= 1f / 10 * Time.deltaTime;
            if (LoadTime >= 10f)
            {
                WrongAnswerImg.SetActive(true);
            }
            
        }
       

    }
       
   
}


