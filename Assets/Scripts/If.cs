using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    float coffeeT = 85.0f;
    float hotLimitT = 70.0f;
    float coldLimitT = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
           TTest();

           coffeeT -= Time.deltaTime * 5f;
    }

    void TTest()
    {
        if (coffeeT > hotLimitT)
        {
            print("coffee is too hot.");
        }
        else if (coffeeT < coldLimitT)
        {
            print("coffee is too cold.");
        }
        else
        {
            print("coffee is just right.");
        }
    }
}

