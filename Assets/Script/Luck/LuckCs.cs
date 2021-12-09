using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LuckCs : MonoBehaviour

{
    public GameObject canvas;
    public Text Level2;// Start is called before the first frame update
    public int i;
    public int type;
    public int type2;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    void Start()
    {
        i = 1;
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    void Update()
    {
        //Level.text = level_stack.ToString();// 레벨 텍스트
        /*
        for (i = 0; i < 4; i++)
        {
            if (i == 1)
            {
                Level2.text = "운빨의 탑에 오신것을 환영합니다.";
                
                Debug.Log("딜레이1");
            }
            if (i == 2)
            {
                Level2.text = "각각 33%의 확률로 -1, 0 +1 의 층레벨이 올라갑니다.";
                Debug.Log("딜레이2");
            }
            if (i == 3)
            {
                Level2.text = "이후 랜덤 탑 버튼이 하나 나옵니다.";
                Debug.Log("딜레이3");
            }
            if (i == 4)
            {
                Level2.text = "행운이 있기를...";
                Debug.Log("딜레이4");

            }

        }*/
        type = Random.Range(1, 7);
        type2 = Random.Range(1, 4);
    }

    private IEnumerator Delay()
    {
        {
            while (true)
            {
                yield return new WaitForSeconds(3.0f);
                Debug.Log("딜레이 코루틴");

                /*for (i = 0; i < 5; i++)
                {
                    if (i == 1)
                    {
                        Level2.text = "운빨의 탑에 오신것을 환영합니다.";

                        Debug.Log("딜레이1");
                    }
                    if (i == 2)
                    {
                        Level2.text = "각각 33%의 확률로 -1, 0 +1 의 층레벨이 올라갑니다.";
                        Debug.Log("딜레이2");
                    }
                    if (i == 3)
                    {
                        Level2.text = "이후 랜덤 탑 버튼이 하나 나옵니다.";
                        Debug.Log("딜레이3");
                    }
                    if (i == 4)
                    {
                        Level2.text = "행운이 있기를...";
                        Debug.Log("딜레이4");

                    }
                }*/

                if (i == 1)
                {
                    Level2.text = "운빨의 탑에 오신것을 환영합니다.";

                    Debug.Log("딜레이1");
                }
                if (i == 2)
                {
                    Level2.text = "각각 33%의 확률로 -1, 0 +1 의 층레벨이 올라갑니다.";
                    Debug.Log("딜레이2");
                }
                if (i == 3)
                {
                    Level2.text = "이후 랜덤 탑 버튼이 하나 나옵니다.";
                    Debug.Log("딜레이3");
                }
                if (i == 4)
                {
                    Level2.text = "행운이 있기를...";
                    Debug.Log("딜레이4");

                }
                if (i == 5)
                {
                    Level2.text = "";
                    Debug.Log("딜레이4");
                    if (type2 == 1)
                    {
                        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
                        TCS2.level_stack -= 1;
                        Level2.text = "층 레벨이 1 하락 했습니다.";
                    }
                    if (type2 == 2)
                    {
                        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
                        TCS2.level_stack += 1;
                        Level2.text = "층 레벨이 1 상승 했습니다.";
                    }
                    if (type2 == 3)
                    {
                        Level2.text = "아무 효과 없었습니다.";
                    }
                    BtnClick();
                }

                i++;
                if (i == 6)
                {
                    break;
                }
            }
        }

    }
    public void BtnClick()
    {
        if (type == 1)
        {
            Button child1 = Instantiate(btn1);
            child1.transform.position = new Vector3(1000, 350, 0);
            child1.transform.parent = canvas.transform;
        }
        if (type == 2)
        {
            Button child1 = Instantiate(btn2);
            child1.transform.position = new Vector3(1000, 350, 0);
            child1.transform.parent = canvas.transform;
        }
        if (type == 3)
        {
            Button child1 = Instantiate(btn3);
            child1.transform.position = new Vector3(1000, 350, 0);
            child1.transform.parent = canvas.transform;
        }
        if (type == 4)
        {
            Button child1 = Instantiate(btn4);
            child1.transform.position = new Vector3(1000, 350, 0);
            child1.transform.parent = canvas.transform;
        }
        if (type == 5)
        {
            Button child1 = Instantiate(btn5);
            child1.transform.position = new Vector3(1000, 350, 0);
            child1.transform.parent = canvas.transform;
        }
        if (type == 6)
        {
            Button child1 = Instantiate(btn6);
            child1.transform.position = new Vector3(1000, 350, 0);
            child1.transform.parent = canvas.transform;
        }
    }
}