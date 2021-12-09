using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    public float pos;
    public GameObject Cam;
    // Start is called before the first frame update
    void Start()
    {
        pos = 0;
        Cam.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (pos >= 1.7)
        {
            
        }
        else
        {
            pos += Time.deltaTime;
            Cam.transform.position += new Vector3(0, pos / 100, 0);
        }
     
    }
}
