using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RunBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();


        if (TCS2.level_stack == 5 || TCS2.level_stack == 10)
        {
            Button a_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            RunBtn b_btn = a_btn.GetComponent<RunBtn>();
            a_btn.onClick.AddListener(() => { b_btn.btn2(); });
        }
        else
        {
            Button m_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            RunBtn c_btn = m_btn.GetComponent<RunBtn>();
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
            SceneManager.LoadScene("Run_2TS");
        }
        if (TCS2.level_stack == 2)
        {
            SceneManager.LoadScene("Run_3TS");
        }
        if (TCS2.level_stack == 3)
        {
            SceneManager.LoadScene("Run_4TS");
        }
        if (TCS2.level_stack == 4)
        {
            SceneManager.LoadScene("Run_5TS");
        }
        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Run_6TS");
        }
        if (TCS2.level_stack == 6)
        {
            SceneManager.LoadScene("Run_7TS");
        }
        if (TCS2.level_stack == 7)
        {
            SceneManager.LoadScene("Run_8TS");
        }
        if (TCS2.level_stack == 8)
        {
            SceneManager.LoadScene("Run_9TS");
        }
        if (TCS2.level_stack == 9)
        {
            SceneManager.LoadScene("Run_10TS");
        }
        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Run_11TS");
        }
        if (TCS2.level_stack == 11)
        {
            SceneManager.LoadScene("Run_12TS");
        }
        if (TCS2.level_stack == 12)
        {
            SceneManager.LoadScene("Run_13TS");
        }
        if (TCS2.level_stack == 13)
        {
            SceneManager.LoadScene("Run_14TS");
        }
        if (TCS2.level_stack == 14)
        {
            SceneManager.LoadScene("Run_15TS");
        }
    }

    public void btn2()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        //ChangeScene CS = GameObject.Find("GameManager").GetComponent<ChangeScene>();
        
        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Run_5TS");
        }
        
        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Run_10TS");
        }
    }


}