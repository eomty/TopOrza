using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathLoad_20sec : MonoBehaviour // 20초 타이머 스크립트
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
        if (LoadTime != 20f)
        {
            LoadTime += Time.deltaTime;
            LoadGauge.fillAmount -= 1f / 20 * Time.deltaTime;
            if (LoadTime >= 20f)
            {
                WrongAnswerImg.SetActive(true);
            }
        }
    }
}

