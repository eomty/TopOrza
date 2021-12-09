using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingTime : MonoBehaviour
{
    
    public Image LoadingGauge;
    public float Loading;


    // Start is called before the first frame update
    void Start()
    {
        Loading = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Loading != 0)
        {
            Loading -= Time.deltaTime;
            LoadingGauge.fillAmount += 1.0f / 2 * Time.deltaTime;
          
        }
    }
}

