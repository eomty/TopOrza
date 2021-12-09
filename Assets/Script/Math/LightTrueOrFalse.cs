using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrueOrFalse : MonoBehaviour
{
    public GameObject Light;
    // Update is called once per frame

    void Start()
    {
        InvokeRepeating("LightOn",2,5);
        InvokeRepeating("LightOff", 4, 5/2);
        
    }
    void LightOn()
    {
            Light.SetActive(true);
        
    }
    void LightOff()
    {
        Light.SetActive(false);
        
    }
}
