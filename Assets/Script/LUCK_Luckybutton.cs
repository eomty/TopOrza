using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LUCK_Luckybutton : MonoBehaviour
{
    public GameObject LuckyButton;
    public GameObject UnLuckyButton;

    public GameObject ClearStageIMG;
    public GameObject GameOverIMG;
    

    public void RandomButton()
    {
        //여기에 럭키 버튼 생성하는 코드를 두면 됨.
    }

    // Start is called before the first frame update
    void OnMousedown()
    {
        if (LuckyButton == true)
        {
            Debug.Log("33% 확률로 성공!");
            GameObject.Instantiate(ClearStageIMG);
        }
        if (UnLuckyButton == true)
        {
            Debug.Log("아쉽군요. 다음 기회에 후후후후후");
            GameObject.Instantiate(GameOverIMG);
        }
        else
        {
            Debug.Log("어이! 뭔가 오류 났다고!");
        }
    }
}
