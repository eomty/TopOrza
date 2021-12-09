using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb_Stone : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject StonePrefab;
    public float TimeLeft = 1.0f;

    public float nextTime = 0.0f;
    public float y;

    void MoveMoles()

    {

        print("moveMole!");
        GameObject go = Instantiate(StonePrefab) as GameObject;
        int px = Random.Range(-8, 8);
        go.transform.position = new Vector3(px, y, 436);

    }

    void Update()

    {

        //StartCoroutine(a());

        //2초마다 실행

        if (Time.time > nextTime)
        {

            nextTime = Time.time + TimeLeft;

            MoveMoles();

        }


        /*
        IEnumerator a()
        {
            while (true)
            {
                GameObject go = Instantiate(StonePrefab) as GameObject;
                int px = Random.Range(-6, 7);
                Debug.Log("10초 안지남ㅋㅋ");
                go.transform.position = new Vector3(px, 7, 7);
                yield return new WaitForSeconds(2);
                Debug.Log("2초지남 사실ㅋㅋ");
            }
        }*/
    }
}