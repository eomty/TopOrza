using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class TopClearSC : MonoBehaviour
{
    //public Text topLevelText;
    //public int score;
    public Text Level;      //Level 값을 표시할 텍스트
    //public Text save;        //save 값을 표시할 텍스트

    public int level_stack;    //level 값

    public bool IsSave;
    //savedScore.ToString(0);

    void Awake()
    {
        IsSave = PlayerPrefs.HasKey("saved_level");



        if (!IsSave)
        {
            Debug.Log("저장된 데이터가 없습니다.");
            level_stack = 0;
            //save_stack = 0;
        }

        //세이브 데이터가 있다면 값을 불러옴
        else
        {
            Debug.Log("저장된 데이터가 있습니다.");
            level_stack = PlayerPrefs.GetInt("saved_level");
        }
    }
    //PlayerPrefs.SetInt("normal", normalScore);


    void Start()
    {
        if (level_stack == 5 || level_stack == 10)
        {
            PlayerPrefs.SetInt("saved_level", level_stack);     //"saved_level" 이라는 키값으로 level_stack 값을 저장시킴
            PlayerPrefs.Save();     //PlayerPrefs를 저장
            Debug.Log("자동저장");
        }
    }
    void Update()
    {
        Level.text = level_stack.ToString();// 레벨 텍스트

        Level.text = "현재: " + level_stack + "층";
    }
    public void Clicked_Save()
    {
        if (level_stack == 5 || level_stack == 10)
        {
            PlayerPrefs.SetInt("saved_level", level_stack);     //"saved_level" 이라는 키값으로 level_stack 값을 저장시킴
            PlayerPrefs.Save();     //PlayerPrefs를 저장
        }
    }

    public void Clicked_Delete()
    {
        PlayerPrefs.DeleteAll();        //Playerprefs의 모든 키 값을 삭제시킴
    }

    public void ScoreUp()
    {
        //score++;
        level_stack++;
    }
}