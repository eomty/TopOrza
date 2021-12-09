using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject OptionIMG; // 옵션 이미지
    public GameObject MethodIMG; // 조작 이미지
    public GameObject Optionzip; // 옵션 내 버튼들

    public void ViewOption()
    {
        OptionIMG.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void OptionOff()
    {
        OptionIMG.SetActive(false);
        Time.timeScale = 1f;
    }


    //구성 씬
    public void ChangeTo_StartScene()
    {
        SceneManager.LoadScene("StartS");//시작화면 씬 : 게임 시작할 때 나오는 화면
    }

    public void ChangeTo_MainScene()
    {
        SceneManager.LoadScene("MainS");//메인 화면 씬:뒤로가면 시작화면으로 이동하고, 탑 오르거나 명예의 탑, 옵션(모드)를 선택 가능
    }
    public void ChangeTo_FameTowerScene()
    {
        SceneManager.LoadScene("FameTS"); //명예의 탑
    }
    public void ChangeTo_Test1Scene()
    {
        SceneManager.LoadScene("Test1S"); // 임시 저장된거 불러오기
    }



    //아래는 탑 씬들 나중에 1~15층까지 늘릴거임


    //1층

    public void ChangeTo_MathTower_1_Scene()
    {
        SceneManager.LoadScene("Math_1TS");
    }
    public void ChangeTo_LuckyTower_1_Scene()
    {
        SceneManager.LoadScene("Luck_1TS");
    }
    public void ChangeTo_MazeTower_1_Scene()
    {
        SceneManager.LoadScene("Maze_1TS");
    }
    public void ChangeTo_RunTower_1_Scene()
    {
        SceneManager.LoadScene("Run_1TS");
    }
    public void ChangeTo_JumpTower_1_Scene()
    {
        SceneManager.LoadScene("Jump_1TS");
    }
    public void ChangeTo_ClimbTower_1_Scene()
    {
        SceneManager.LoadScene("Climb_1TS");
    }

        //2층
    public void ChangeTo_MathTower_2_Scene()
    {
        SceneManager.LoadScene("Math_2TS");
    }

    public void ChangeTo_MazeTower_2_Scene()
    {
        SceneManager.LoadScene("Maze_2TS");
    }
    public void ChangeTo_RunTower_2_Scene()
    {
        SceneManager.LoadScene("Run_2TS");
    }
    public void ChangeTo_JumpTower_2_Scene()
    {
        SceneManager.LoadScene("Jump_2TS");
    }
    public void ChangeTo_ClimbTower_2_Scene()
    {
        SceneManager.LoadScene("Climb_2TS");
    }


    //3층
    public void ChangeTo_MathTower_3_Scene()
    {
        SceneManager.LoadScene("Math_3TS");
    }

    public void ChangeTo_MazeTower_3_Scene()
    {
        SceneManager.LoadScene("Maze_3TS");
    }
    public void ChangeTo_RunTower_3_Scene()
    {
        SceneManager.LoadScene("Run_3TS");
    }
    public void ChangeTo_JumpTower_3_Scene()
    {
        SceneManager.LoadScene("Jump_3TS");
    }
    public void ChangeTo_ClimbTower_3_Scene()
    {
        SceneManager.LoadScene("Climb_3TS");
    }

    //4층
    public void ChangeTo_MathTower_4_Scene()
    {
        SceneManager.LoadScene("Math_4TS");
    }

    public void ChangeTo_MazeTower_4_Scene()
    {
        SceneManager.LoadScene("Maze_4TS");
    }
    public void ChangeTo_RunTower_4_Scene()
    {
        SceneManager.LoadScene("Run_4TS");
    }
    public void ChangeTo_JumpTower_4_Scene()
    {
        SceneManager.LoadScene("Jump_4TS");
    }
    public void ChangeTo_ClimbTower_4_Scene()
    {
        SceneManager.LoadScene("Climb_4TS");
    }

    //5층
    public void ChangeTo_MathTower_5_Scene()
    {
        SceneManager.LoadScene("Math_5TS");
    }

    public void ChangeTo_MazeTower_5_Scene()
    {
        SceneManager.LoadScene("Maze_5TS");
    }
    public void ChangeTo_RunTower_5_Scene()
    {
        SceneManager.LoadScene("Run_5TS");
    }
    public void ChangeTo_JumpTower_5_Scene()
    {
        SceneManager.LoadScene("Jump_5TS");
    }
    public void ChangeTo_ClimbTower_5_Scene()
    {
        SceneManager.LoadScene("Climb_5TS");
    }


    //6층
    public void ChangeTo_MathTower_6_Scene()
    {
        SceneManager.LoadScene("Math_6TS");
    }

    public void ChangeTo_MazeTower_6_Scene()
    {
        SceneManager.LoadScene("Maze_6TS");
    }
    public void ChangeTo_RunTower_6_Scene()
    {
        SceneManager.LoadScene("Run_6TS");
    }
    public void ChangeTo_JumpTower_6_Scene()
    {
        SceneManager.LoadScene("Jump_6TS");
    }
    public void ChangeTo_ClimbTower_6_Scene()
    {
        SceneManager.LoadScene("Climb_6TS");
    }


    //7층
    public void ChangeTo_MathTower_7_Scene()
    {
        SceneManager.LoadScene("Math_7TS");
    }

    public void ChangeTo_MazeTower_7_Scene()
    {
        SceneManager.LoadScene("Maze_7TS");
    }
    public void ChangeTo_RunTower_7_Scene()
    {
        SceneManager.LoadScene("Run_7TS");
    }
    public void ChangeTo_JumpTower_7_Scene()
    {
        SceneManager.LoadScene("Jump_7TS");
    }
    public void ChangeTo_ClimbTower_7_Scene()
    {
        SceneManager.LoadScene("Climb_7TS");
    }


    //8층
    public void ChangeTo_MathTower_8_Scene()
    {
        SceneManager.LoadScene("Math_8TS");
    }

    public void ChangeTo_MazeTower_8_Scene()
    {
        SceneManager.LoadScene("Maze_8TS");
    }
    public void ChangeTo_RunTower_8_Scene()
    {
        SceneManager.LoadScene("Run_8TS");
    }
    public void ChangeTo_JumpTower_8_Scene()
    {
        SceneManager.LoadScene("Jump_8TS");
    }
    public void ChangeTo_ClimbTower_8_Scene()
    {
        SceneManager.LoadScene("Climb_8TS");
    }


    //9층
    public void ChangeTo_MathTower_9_Scene()
    {
        SceneManager.LoadScene("Math_9TS");
    }

    public void ChangeTo_MazeTower_9_Scene()
    {
        SceneManager.LoadScene("Maze_9TS");
    }
    public void ChangeTo_RunTower_9_Scene()
    {
        SceneManager.LoadScene("Run_9TS");
    }
    public void ChangeTo_JumpTower_9_Scene()
    {
        SceneManager.LoadScene("Jump_9TS");
    }
    public void ChangeTo_ClimbTower_9_Scene()
    {
        SceneManager.LoadScene("Climb_9TS");
    }


    //10층
    public void ChangeTo_MathTower_10_Scene()
    {
        SceneManager.LoadScene("Math_10TS");
    }

    public void ChangeTo_MazeTower_10_Scene()
    {
        SceneManager.LoadScene("Maze_10TS");
    }
    public void ChangeTo_RunTower_10_Scene()
    {
        SceneManager.LoadScene("Run_10TS");
    }
    public void ChangeTo_JumpTower_10_Scene()
    {
        SceneManager.LoadScene("Jump_10TS");
    }
    public void ChangeTo_ClimbTower_10_Scene()
    {
        SceneManager.LoadScene("Climb_10TS");
    }


    //11층
    public void ChangeTo_MathTower_11_Scene()
    {
        SceneManager.LoadScene("Math_11TS");
    }

    public void ChangeTo_MazeTower_11_Scene()
    {
        SceneManager.LoadScene("Maze_11TS");
    }
    public void ChangeTo_RunTower_11_Scene()
    {
        SceneManager.LoadScene("Run_11TS");
    }
    public void ChangeTo_JumpTower_11_Scene()
    {
        SceneManager.LoadScene("Jump_11TS");
    }
    public void ChangeTo_ClimbTower_11_Scene()
    {
        SceneManager.LoadScene("Climb_11TS");
    }


    //2층
    public void ChangeTo_MathTower_12_Scene()
    {
        SceneManager.LoadScene("Math_12TS");
    }

    public void ChangeTo_MazeTower_12_Scene()
    {
        SceneManager.LoadScene("Maze_12TS");
    }
    public void ChangeTo_RunTower_12_Scene()
    {
        SceneManager.LoadScene("Run_12TS");
    }
    public void ChangeTo_JumpTower_12_Scene()
    {
        SceneManager.LoadScene("Jump_12TS");
    }
    public void ChangeTo_ClimbTower_12_Scene()
    {
        SceneManager.LoadScene("Climb_12TS");
    }


    //13층
    public void ChangeTo_MathTower_13_Scene()
    {
        SceneManager.LoadScene("Math_13TS");
    }

    public void ChangeTo_MazeTower_13_Scene()
    {
        SceneManager.LoadScene("Maze_13TS");
    }
    public void ChangeTo_RunTower_13_Scene()
    {
        SceneManager.LoadScene("Run_13TS");
    }
    public void ChangeTo_JumpTower_13_Scene()
    {
        SceneManager.LoadScene("Jump_13TS");
    }
    public void ChangeTo_ClimbTower_13_Scene()
    {
        SceneManager.LoadScene("Climb_13TS");
    }


    //14층
    public void ChangeTo_MathTower_14_Scene()
    {
        SceneManager.LoadScene("Math_14TS");
    }

    public void ChangeTo_MazeTower_14_Scene()
    {
        SceneManager.LoadScene("Maze_14TS");
    }
    public void ChangeTo_RunTower_14_Scene()
    {
        SceneManager.LoadScene("Run_14TS");
    }
    public void ChangeTo_JumpTower_14_Scene()
    {
        SceneManager.LoadScene("Jump_14TS");
    }
    public void ChangeTo_ClimbTower_14_Scene()
    {
        SceneManager.LoadScene("Climb_14TS");
    }

    //15층
    public void ChangeTo_MathTower_15_Scene()
    {
        SceneManager.LoadScene("Math_15TS");
    }

    public void ChangeTo_MazeTower_15_Scene()
    {
        SceneManager.LoadScene("Maze_15TS");
    }
    public void ChangeTo_RunTower_15_Scene()
    {
        SceneManager.LoadScene("Run_15TS");
    }
    public void ChangeTo_JumpTower_15_Scene()
    {
        SceneManager.LoadScene("Jump_15TS");
    }
    public void ChangeTo_ClimbTower_15_Scene()
    {
        SceneManager.LoadScene("Climb_15TS");
    }



  



    //아래는 엔딩 씬들 (12개 정도?)

    public void ChangeTo_Ending_1_Scene()
    {
        SceneManager.LoadScene("Ending_1S");
    }
    public void ChangeTo_Ending_2_Scene()
    {
        SceneManager.LoadScene("Ending_2S");
    }
    public void ChangeTo_Ending_3_Scene()
    {
        SceneManager.LoadScene("Ending_3S");
    }
    public void ChangeTo_Ending_4_Scene()
    {
        SceneManager.LoadScene("Ending_4S");
    }
    public void ChangeTo_Ending_5_Scene()
    {
        SceneManager.LoadScene("Ending_5S");
    }
    public void ChangeTo_Ending_6_Scene()
    {
        SceneManager.LoadScene("Ending_6S");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
   public void ViewMethod()
    {
        MethodIMG.SetActive(true);
        Optionzip.SetActive(false);
    }

    public void MethodOff()
    {
        MethodIMG.SetActive(false);
        Optionzip.SetActive(true);
    }
}
