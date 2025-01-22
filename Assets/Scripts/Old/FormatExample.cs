using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormatExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.LogFormat("I am {0}. I am {1} years old.", "Iron Man", 55);
        //Debug.Log($"I am {"Iron Man"}. I am {55} years old.");
        // Debug.LogFormat("I am {0}. I am {1} years old.", "Super Man", 100);
        // Debug.LogFormat("I am {0}. you are not {0}", " Thor");

        float Value1 = 123;
        // Debug.Log(Value1.ToString("00000")); // "0" 0자리 표시
        // Debug.Log(string.Format("value1 is {0:00000}", Value1));
        Debug.Log($"value1 is {Value1:0000}");

        // Debug.Log(Value1.ToString("#####")); // "#" 10진수 자리표시
        // Debug.Log(string.Format("value1 is {0:#####}", Value1));
        Debug.Log($"value1 is {Value1:#####}");

        float value2 = 1.23f;
       // Debug.Log(value2.ToString("0.0")); // "." 소수점 
       // Debug.Log(string.Format("value2 is {0:0.00}", value2));
        Debug.Log($"value2 is {value2:0.0}");

        float value3 = 1234567890;
        // Debug.Log(value3.ToString("#,#")); // ',' 천자리
        // Debug.Log(string.Format("value3 is {0:#,#}", value3));
        Debug.Log($"value3 is {value3:#,#}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
