using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_text : MonoBehaviour
   
{
    public Text Level2;// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TopClearSC TCSC = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        Level2.text=TCSC.level_stack.ToString();
       // Level.text = level_stack.ToString();// 레벨 텍스트

        Level2.text = "현재 ' " + TCSC.level_stack + " '층 저장 됬습니다.";
    }
}
