using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathLoad_30sec : MonoBehaviour
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
        if (LoadTime != 30f)
        {
            LoadTime += Time.deltaTime;
            LoadGauge.fillAmount -= 1 / 30f * Time.deltaTime;
            if (LoadTime >= 30f)
            {
                WrongAnswerImg.SetActive(true);
            }
        }
    }
}
