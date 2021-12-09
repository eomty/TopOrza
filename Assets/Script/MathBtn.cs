using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MathBtn : MonoBehaviour
{
    //public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();


        if (TCS2.level_stack == 5 || TCS2.level_stack == 10)
        {
            Button a_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            MathBtn b_btn = a_btn.GetComponent<MathBtn>();
            a_btn.onClick.AddListener(() => { b_btn.btn2(); });
        }
        else
        {
            Button m_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            MathBtn c_btn = m_btn.GetComponent<MathBtn>();
            m_btn.onClick.AddListener(() => { c_btn.btn(); });
        }


    }

    public void btn()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        //ChangeScene CS = GameObject.Find("GameManager").GetComponent<ChangeScene>();
        if (TCS2.level_stack == 1)
        {
            //CS.ChangeTo_MathTower_2_Scene(); 안됌 망할
            SceneManager.LoadScene("Math_2TS");
        }
        if (TCS2.level_stack == 2)
        {
            SceneManager.LoadScene("Math_3TS");
        }
        if (TCS2.level_stack == 3)
        {
            SceneManager.LoadScene("Math_4TS");
        }
        if (TCS2.level_stack == 4)
        {
            SceneManager.LoadScene("Math_5TS");
        }
        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Math_6TS");
        }
        if (TCS2.level_stack == 6)
        {
            SceneManager.LoadScene("Math_7TS");
        }
        if (TCS2.level_stack == 7)
        {
            SceneManager.LoadScene("Math_8TS");
        }
        if (TCS2.level_stack == 8)
        {
            SceneManager.LoadScene("Math_9TS");
        }
        if (TCS2.level_stack == 9)
        {
            SceneManager.LoadScene("Math_10TS");
        }
        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Math_11TS");
        }
        if (TCS2.level_stack == 11)
        {
            SceneManager.LoadScene("Math_12TS");
        }
        if (TCS2.level_stack == 12)
        {
            SceneManager.LoadScene("Math_13TS");
        }
        if (TCS2.level_stack == 13)
        {
            SceneManager.LoadScene("Math_14TS");
        }
        if (TCS2.level_stack == 14)
        {
            SceneManager.LoadScene("Math_15TS");
        }
        if (TCS2.level_stack == 15)
        {
            SceneManager.LoadScene("EndingS");/////////////////헬프
        }
    }
    public void btn2()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        //ChangeScene CS = GameObject.Find("GameManager").GetComponent<ChangeScene>();

        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Math_5TS");
        }

        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Math_10TS");
        }
    }

}
