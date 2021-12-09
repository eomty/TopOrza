using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MATH_MathQuestion_Orign : MonoBehaviour
{
    public GameObject Answer1;
    public GameObject Answer2;
    public GameObject Answer3;
    public GameObject Answer4;
    public GameObject Answer5;

    public GameObject TrueAnswer; // 정답


    public GameObject RightAnswerIMG; // 맞히면 정답 이미지 출력
    public GameObject WrongAnswerIMG;// 틀리면 틀린 답 이미지 출력

    public GameObject LoadingGauge;



    // Start is called before the first frame update
   public void OnMouseDown()
    {
        LoadingGauge.SetActive(false);
        if (Answer1 == true)
        {
            Debug.Log("1번 버튼을 클릭함");
            if (TrueAnswer == true)
            {
                Debug.Log("정답입니다.");
                RightAnswerIMG.SetActive(true);
            }
            else
            {
                Debug.Log("틀렸습니다.");
                WrongAnswerIMG.SetActive(true);
            }
        }

        if (Answer2 == true)
        {
            Debug.Log("2번 버튼을 클릭함");
            if (TrueAnswer == true)
            {
                Debug.Log("정답입니다.");
                RightAnswerIMG.SetActive(true);
            }

            else
            {
                Debug.Log("틀렸습니다.");
                WrongAnswerIMG.SetActive(true);
            }
        }
        if (Answer3 == true)
        {
            Debug.Log("3번 버튼을 클릭함");
            if (TrueAnswer == true)
            {
                Debug.Log("정답입니다.");
                RightAnswerIMG.SetActive(true);
            }

            else
            {
                Debug.Log("틀렸습니다.");
                WrongAnswerIMG.SetActive(true);
            }
        }
        if (Answer4 == true)
        {
            Debug.Log("4번 버튼을 클릭함");
            if (TrueAnswer == true)
            {
                Debug.Log("정답입니다.");
                RightAnswerIMG.SetActive(true);
            }

            else
            {
                Debug.Log("틀렸습니다.");
                WrongAnswerIMG.SetActive(true);
            }
        }
        if (Answer5 == true)
        {
            Debug.Log("5번 버튼을 클릭함");
            if (TrueAnswer == true)
            {
                Debug.Log("정답입니다.");
                RightAnswerIMG.SetActive(true);

            }

            else
            {
                Debug.Log("틀렸습니다.");
                WrongAnswerIMG.SetActive(true);
            }
        }
        else
        {
            Debug.Log("오류 발생");
        }
    }
}
