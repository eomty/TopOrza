using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        

        if (collision.gameObject.CompareTag("End") || collision.gameObject.CompareTag("Player")|| collision.gameObject.CompareTag("Hill")|| collision.gameObject.CompareTag("Ground2"))
        {
            Destroy(gameObject);

        }
        else
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
    }
}
