using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ju6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TopClearSC TCSC = GameObject.Find("GameManager").GetComponent<TopClearSC>();
        TCSC.level_stack = 6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
