using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class JumpExample : MonoBehaviour
{
    
    void Start()
    {
        // continue 문 : 반복문이 아래 실행문실행 x 반복으로 이동
        for ( int i = 0; i < 10; i++)
        {
            if ( i < 7 )
            {
                Debug.Log($"i:{i}");
                continue; // 0~6 일 결루 아래 debug.log로 가지 않고 다음 for 문으로 감
                Debug.Log("under continue");
            }
            Debug.Log(i); // 출력 :  7 8 9
        }
        
        /*   switch 문
        int n = 2;
        switch (n)
        {
            case 1:
                 break;

            case 2:
                    for( int i=0; i < 5; i++)
                    {
                        if (i ==2 )
                        {
                            break;
                        }
                        Debug.Log($"n:{n}, i:{i}");
                    }
                      break;
                
                default:
                    break;
        }
        */
        /*        for 문
        for (int k = 0; k < 2; k++)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Debug.Log(i);
            }
        }
        */
    }

    void Update()
    {
        
    }
}
