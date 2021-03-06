using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathLoad_50sec : MonoBehaviour
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
        if (LoadTime != 50f)
        {
            LoadTime += Time.deltaTime;
            LoadGauge.fillAmount -= 1f / 50 * Time.deltaTime;
            if (LoadTime >= 50f)
            {
                WrongAnswerImg.SetActive(true);
            }
        }
    }
}
