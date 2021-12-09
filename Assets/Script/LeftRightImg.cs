using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightImg : MonoBehaviour
{
    public GameObject MoveMentImg;
    public int movespeed;
    public float i;
    public bool eomtyhelp;
    public bool eomtyhelp2;
    public GameObject TempObj;
    public GameObject TempObj2;

    // Start is called before the first frame update

    void Awake()
    {
        TempObj = GameObject.Find("RightButton");
        TempObj2 = GameObject.Find("LeftButton");
    }
    void Start()
    {
        movespeed = 2222;
        eomtyhelp = false;
        eomtyhelp2 = false;

        MoveMentImg.transform.position = new Vector3(960,540, 0);
    }

    void Update() {

        if (eomtyhelp == true)
        {
            i += Time.deltaTime;
            MoveMentImg.transform.Translate(Vector3.left * movespeed * Time.deltaTime);
            
        }

        if (eomtyhelp2 == true)
        {
            i -= Time.deltaTime;
            MoveMentImg.transform.Translate(Vector3.right * movespeed * Time.deltaTime);
            
        }

        if (i >= 0.6f)
        {
            TempObj.SetActive(false);
        }
        if (i <= -0.6f)
        {
            TempObj2.SetActive(false);
        }

    }

    public void Left()
    {
        eomtyhelp=true;
        TempObj.SetActive(false);
        TempObj2.SetActive(false);
        StartCoroutine(DelayControl());
        
    }

    public void Right()
    {
        eomtyhelp2 = true;
        TempObj.SetActive(false);
        TempObj2.SetActive(false);
        StartCoroutine(DelayControl());
        
    }

    IEnumerator DelayControl()
    {
        Debug.Log("딜레이");
        yield return new WaitForSeconds(0.6332f); //딜레이니까 니가 조절해 수치
        eomtyhelp = false;
        eomtyhelp2 = false;
        TempObj.SetActive(true);
        TempObj2.SetActive(true);

    }




 


}
