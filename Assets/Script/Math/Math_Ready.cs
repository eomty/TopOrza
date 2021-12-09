using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Math_Ready : MonoBehaviour
{
    public GameObject Quest;
    public GameObject ReadyButton;
    public GameObject QuestTimebar;
 
    // Start is called before the first frame update
    void Start()
    {
        Quest.SetActive(false);
        QuestTimebar.SetActive(false);

    }

    // Update is called once per frame
    public void ReadyGo()
    {
        Quest.SetActive(true);
        ReadyButton.SetActive(false);
        QuestTimebar.SetActive(true);

    }

}
