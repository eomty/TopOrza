using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LuckBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();


        if (TCS2.level_stack == 5 || TCS2.level_stack == 10)
        {
            Button a_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            LuckBtn b_btn = a_btn.GetComponent<LuckBtn>();
            a_btn.onClick.AddListener(() => { b_btn.btn2(); });
        }
        else
        {
            Button m_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            LuckBtn c_btn = m_btn.GetComponent<LuckBtn>();
            m_btn.onClick.AddListener(() => { c_btn.btn(); });
        }


    }

    public void btn()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        //ChangeScene CS = GameObject.Find("GameManager").GetComponent<ChangeScene>();
        if (TCS2.level_stack == 0)
        {
            //CS.ChangeTo_MathTower_2_Scene(); 안됌 망할
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 1)
        {
            //CS.ChangeTo_MathTower_2_Scene(); 안됌 망할
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 2)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 3)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 4)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 6)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 7)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 8)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 9)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 11)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 12)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 13)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
        if (TCS2.level_stack == 14)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
    }
    public void btn2()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        //ChangeScene CS = GameObject.Find("GameManager").GetComponent<ChangeScene>();

        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Luck_1TS");
        }

        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Luck_1TS");
        }
    }

}