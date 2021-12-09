using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClimbBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();


        if (TCS2.level_stack == 5 ||  TCS2.level_stack == 10)
        {
            Button a_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            ClimbBtn b_btn = a_btn.GetComponent<ClimbBtn>();
            a_btn.onClick.AddListener(() => { b_btn.btn2(); });
        }
        else
        {
            Button m_btn = this.transform.GetComponent<Button>();
            //m_btn.onClick.AddListener(fClick);

            ClimbBtn c_btn = m_btn.GetComponent<ClimbBtn>();
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
            SceneManager.LoadScene("Climb_2TS");
        }
        if (TCS2.level_stack == 2)
        {
            SceneManager.LoadScene("Climb_3TS");
        }
        if (TCS2.level_stack == 3)
        {
            SceneManager.LoadScene("Climb_4TS");
        }
        if (TCS2.level_stack == 4)
        {
            SceneManager.LoadScene("Climb_5TS");
        }
        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Climb_6TS");
        }
        if (TCS2.level_stack == 6)
        {
            SceneManager.LoadScene("Climb_7TS");
        }
        if (TCS2.level_stack == 7)
        {
            SceneManager.LoadScene("Climb_8TS");
        }
        if (TCS2.level_stack == 8)
        {
            SceneManager.LoadScene("Climb_9TS");
        }
        if (TCS2.level_stack == 9)
        {
            SceneManager.LoadScene("Climb_10TS");
        }
        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Climb_11TS");
        }
        if (TCS2.level_stack == 11)
        {
            SceneManager.LoadScene("Climb_12TS");
        }
        if (TCS2.level_stack == 12)
        {
            SceneManager.LoadScene("Climb_13TS");
        }
        if (TCS2.level_stack == 13)
        {
            SceneManager.LoadScene("Climb_14TS");
        }
        if (TCS2.level_stack == 14)
        {
            SceneManager.LoadScene("Climb_15TS");
        }
    }
    public void btn2()
    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        //ChangeScene CS = GameObject.Find("GameManager").GetComponent<ChangeScene>();

        if (TCS2.level_stack == 5)
        {
            SceneManager.LoadScene("Climb_5TS");
        }

        if (TCS2.level_stack == 10)
        {
            SceneManager.LoadScene("Climb_10TS");
        }
    }


}