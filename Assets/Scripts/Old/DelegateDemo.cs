using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateDemo : MonoBehaviour
{
    // delegate 선언
    delegate float SumHandler (float a, float b);
    // 델리게이트 타입 변수 선언
    SumHandler sumHandler;

    float Sum(float a, float b)
    {
        return a + b;
    }
  
    void Start()
    {
        sumHandler = Sum;
        float sum = sumHandler(10.0f, 5.0f);

        Debug.Log($"Sum = {sum}");        
    }

}
