using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MATH_MathQuestion : MonoBehaviour
{
    


    public GameObject RightAnswerIMG; // 맞히면 정답 이미지 출력
    public GameObject WrongAnswerIMG;// 틀리면 틀린 답 이미지 출력

    public GameObject LoadingGauge;


    

    public void answer1()
    {
        Debug.Log("1번 버튼을 클릭했습니다.");
    }
    public void answer2()
    {
        Debug.Log("2번 버튼을 클릭했습니다.");
    }
    public void answer3()
    {
        Debug.Log("3번 버튼을 클릭했습니다.");
    }
    public void answer4()
    {
        Debug.Log("4번 버튼을 클릭했습니다.");
    }
    public void answer5()
    {
        Debug.Log("5번 버튼을 클릭했습니다.");
    }

    public void RightAnswer()
    {
        RightAnswerIMG.SetActive(true);
        GameObject.Destroy(LoadingGauge);
    }
    public void WrongAnswer()
    {
        WrongAnswerIMG.SetActive(true);
        GameObject.Destroy(LoadingGauge);
    }
}