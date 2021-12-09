using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{


    public GameObject LoadingIMG1;
    public GameObject LoadingIMG2;



    // Start is called before the first frame update
    void Start()
    {
      
        InvokeRepeating("Load1", 0f, 0.5f);


        
    }

    void Load1()
    {
        if (LoadingIMG1.active)
        {
            LoadingIMG1.SetActive(false);
            LoadingIMG2.SetActive(true);
            Debug.Log("배경1 출력");
        }
        else
        {
            LoadingIMG1.SetActive(true);
            LoadingIMG2.SetActive(false);
            Debug.Log("배경2 출력");
        }
    }

}