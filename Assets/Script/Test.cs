using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    //public Button btn10;
    public Image image;
    public GameObject canvas;
    public Button btn;
    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btn5;
    public Button btn6;
    float xx = 350;
    /*
    public GameObject prefabs1;
    public GameObject prefabs2;
    public GameObject prefabs3;
    public GameObject prefabs4;
    public GameObject prefabs5;
    public GameObject prefabs6;
    public List<GameObject> GameList = new List<GameObject>();
    */
    public int help;
    //public int TCS2;


    void Start()
    {/*
        GameObject _obj = Instantiate(prefabs1) as GameObject;
        GameObject _obj2 = Instantiate(prefabs2) as GameObject;
        GameObject _obj3 = Instantiate(prefabs3) as GameObject;
        GameObject _obj4 = Instantiate(prefabs3) as GameObject;
        GameObject _obj5 = Instantiate(prefabs3) as GameObject;
        GameObject _obj6 = Instantiate(prefabs3) as GameObject;
        GameList.Add(_obj);
        GameList.Add(_obj2);
        GameList.Add(_obj3);
        GameList.Add(_obj4);
        GameList.Add(_obj5);
        GameList.Add(_obj6);
        */
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        if(TCS2.level_stack >= 5)
            {
            TCS2.level_stack = 5;
        }else if (TCS2.level_stack >= 10)
        {
            TCS2.level_stack = 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameList);
        help = Random.Range(1, 121);
        //Debug.Log(help);
    }


    public void Btn2()

    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        TCS2.Clicked_Delete();
    }


    public void Btn()

    {
        TopClearSC TCS2 = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        //TCS2.ScoreUp(); 

        ////////////////////////////////////점수올리는거 여깄따 이거써야함 ㅡㅡ
        /*
        if (TCS2.level_stack == 5 || TCS2.level_stack == 10)
        {
            TCS2.Clicked_Save();
        }
        */
        //TopClearSc2 ts= GameObject.Find("GameManager").GetComponent<TopClearSc2>().score;

        /*
        int rand = Random.Range(0, GameList.Count);
        print(GameList[rand]);
        GameObject value = GameList.Last();
        GameList.RemoveAt(rand);
        */
        if (TCS2.level_stack != 0) { 
        switch (help)
        {
            case 1:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;

            case 2:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 3:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 4:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 5:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 6:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 7:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 8:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 9:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 10:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 11:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 12:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 13:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 14:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 15:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 16:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 17:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 18:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 19:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 20:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 21:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 22:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 23:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 24:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 25:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 26:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 27:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 28:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 29:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 30:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 31:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 32:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 33:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 34:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 35:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 36:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 37:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 38:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 39:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 40:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 41:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 42:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 43:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 44:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 45:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 46:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 47:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 48:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 49:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 50:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 51:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 52:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 53:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 54:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 55:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 56:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 57:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 58:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 59:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 60:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 61:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 62:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 63:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 64:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 65:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 66:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 67:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 68:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 69:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 70:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 71:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 72:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 73:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 74:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 75:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 76:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 77:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 78:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 79:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 80:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 81:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 82:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 83:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 84:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 85:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 86:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 87:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 88:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 89:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 90:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 91:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 92:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 93:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 94:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 95:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 96:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 97:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 98:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 99:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 100:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 101:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 102:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 103:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 104:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 105:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 106:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 107:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 108:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 109:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 110:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 111:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 112:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 113:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 114:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 115:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 116:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 117:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn1);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 118:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn2);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 119:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn3);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
            case 120:
                for (int i = 0; i < 3; i++)

                {
                    if (i == 0)
                    {
                        Button child = Instantiate(btn6);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=1");
                    }
                    if (i == 1)
                    {
                        Button child = Instantiate(btn5);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=2");
                    }
                    if (i == 2)
                    {
                        Button child = Instantiate(btn4);
                        child.transform.position = new Vector3(xx, 250, 0);
                        xx += 580;
                        child.transform.parent = canvas.transform;
                        Debug.Log("i=3");
                    }
                }
                break;
        }
        }
        else if(TCS2.level_stack==0)
        {
            StartCoroutine(Abcd());
            //언젠간 오류가 날거같아 하..

            
        }
        Test_btn TB = GameObject.Find("SaveLoadButton").GetComponent<Test_btn>();
        TB.BtnClick();





















        /*
                for (int i = 0; i < 3; i++)

        {
            if (i == 0)
            {
                Button child = Instantiate(btn);
                child.transform.position = new Vector3(xx, 250, 0);
                xx += 580;
                child.transform.parent = canvas.transform;
                Debug.Log("i=1");
            }
            if (i == 1)
            {
                Button child = Instantiate(btn);
                child.transform.position = new Vector3(xx, 250, 0);
                xx += 580;
                child.transform.parent = canvas.transform;
                Debug.Log("i=2");
            }
            if (i == 2)
            {
                Button child = Instantiate(btn);
                child.transform.position = new Vector3(xx, 250, 0);
                xx += 580;
                child.transform.parent = canvas.transform;
                Debug.Log("i=3");
            }
            

        } */
    }
    IEnumerator Abcd()
    { 

            image.gameObject.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("MainS");
        
    }


}






