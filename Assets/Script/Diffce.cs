using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diffce : MonoBehaviour
{
    public Material ButtonView;

    public float time;
    private byte i;
    

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        i = 0;
        
        ButtonView.color = new Color32(255, 255,255, i);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1.7f)
        {       
            
            if (i < 254)
            {
                ButtonView.color = new Color32(255, 255, 255, i += 2);

            }
            else if (i > 255)
            {
                ButtonView.color = new Color32(255, 255, 255, 255);
            }
        }
    }
    
}
