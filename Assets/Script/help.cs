using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class help : MonoBehaviour
{

    // Use this for initialization

    //public Transform prefab;
    public GameObject pfClone;
    public GameObject pfClone2;
    public GameObject pfClone3;
    public GameObject goEmpty;
    public int what;
    public int what2;
    public int what3;


    void Update()
    {
        /*int ranLength = 9;
        int[] ranArr = Enumerable.Range(0, ranLength).ToArray();

        for(int i=0; i<ranLength; ++i)
        {
            int ranIdx = Random.Range(i, ranLength);

            int tmp = ranArr[ranIdx];
            ranArr[ranIdx] = ranArr[i];
            ranArr[i] = tmp;
        }
        */


        what = Random.Range(1, 4);
        what2 = Random.Range(1, 4);
        what3 = Random.Range(1, 4);
    }

    public void NewObj()
    {

        switch (what)
        {
            case 1:
                GameObject goTemp = Instantiate(pfClone, new Vector3(250, 450), Quaternion.identity) as GameObject;
                goTemp.transform.parent = goEmpty.transform;
                break;
            case 2:
                GameObject goTemp2 = Instantiate(pfClone2, new Vector3(250, 450), Quaternion.identity) as GameObject;
                goTemp2.transform.parent = goEmpty.transform;
                break;
            case 3:
                GameObject goTemp3 = Instantiate(pfClone3, new Vector3(250, 450), Quaternion.identity) as GameObject;
                goTemp3.transform.parent = goEmpty.transform;
                break;
            default:
                Debug.Log("망했어우린");
                break;
        }

        switch (what2)
        {
            case 1:
                GameObject goTemp4 = Instantiate(pfClone, new Vector3(650, 450), Quaternion.identity) as GameObject;
                goTemp4.transform.parent = goEmpty.transform;
                break;
            case 2:
                GameObject goTemp5 = Instantiate(pfClone2, new Vector3(650, 450), Quaternion.identity) as GameObject;
                goTemp5.transform.parent = goEmpty.transform;
                break;
            case 3:
                GameObject goTemp6 = Instantiate(pfClone3, new Vector3(650, 450), Quaternion.identity) as GameObject;
                goTemp6.transform.parent = goEmpty.transform;
                break;
            default:
                Debug.Log("망했어우린");
                break;
        }

        switch (what3)
        {
            case 1:
                GameObject goTemp7 = Instantiate(pfClone, new Vector3(1050, 450), Quaternion.identity) as GameObject;
                goTemp7.transform.parent = goEmpty.transform;

                break;
            case 2:
                GameObject goTemp8 = Instantiate(pfClone2, new Vector3(1050, 450), Quaternion.identity) as GameObject;
                goTemp8.transform.parent = goEmpty.transform;
                break;
            case 3:
                GameObject goTemp9 = Instantiate(pfClone3, new Vector3(1050, 450), Quaternion.identity) as GameObject;
                goTemp9.transform.parent = goEmpty.transform;
                break;
            default:
                Debug.Log("망했어우린");
                break;
        }
    }
}