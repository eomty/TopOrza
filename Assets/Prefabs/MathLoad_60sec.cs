using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathLoad_60sec : MonoBehaviour
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
        if (LoadTime != 60f)
        {
            LoadTime += Time.deltaTime;
            LoadGauge.fillAmount -= 1f / 60 * Time.deltaTime;
            if (LoadTime >= 60f)
            {
                WrongAnswerImg.SetActive(true);
            }
        }
    }
}
