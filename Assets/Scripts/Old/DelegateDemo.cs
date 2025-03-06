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
        // 델리 게이트 변수에 함수 연결
        sumHandler = Sum;
        //델리 게이트 실행
        float sum = sumHandler(10.0f, 5.0f);
        // float sum = sum(10.05f, 5.0f);

        // 결괏값 출력
        Debug.Log($"Sum = {sum}");

        // 델리게이트 변수에 람다식 선언
        sumHandler = (float a, float b) => (a+b);
        //sumHandler = ( a,b ) => ( a+b );     줄여 쓸수있는부분 
        float sum2 = sumHandler(10.0f, 5.0f);
        Debug.Log($"Sum2 = {sum2}");

        // 델리게이트 변수에 무명 메시드 연결
        sumHandler = delegate(float a, float b) {return a + b; };
        float sum3 = sumHandler(2.0f, 3.0f);
        Debug.Log($"Sum3 = {sum3}");        
    }

}
