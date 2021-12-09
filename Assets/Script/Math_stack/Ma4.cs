using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ma4 : MonoBehaviour
{
  
    void Start()
    {
        TopClearSC TCSC = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        TCSC.level_stack = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
