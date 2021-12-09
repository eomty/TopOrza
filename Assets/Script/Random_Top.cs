using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Random_Top : MonoBehaviour
{
    public int help;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        help = Random.Range(1,7);
    }

    public void RandomTop()

    {
        TopClearSC TCSC = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        TCSC.level_stack = 1;

        switch (help)
        {
            case 1:
                {
                    SceneManager.LoadScene("Jump_1TS");
                }
                break;
            case 2:
                {
                    SceneManager.LoadScene("Maze_1TS");
                }
                break;
            case 3:
                {
                    SceneManager.LoadScene("Run_1TS");
                }
                break;
            case 4:
                {
                    SceneManager.LoadScene("Climb_1TS");
                }
                break;
            case 5:
                {
                    SceneManager.LoadScene("Run_1TS");
                }
                break;
            case 6:
                {
                    SceneManager.LoadScene("Jump_1TS");
                }
                break;
            
        }
    }
}
