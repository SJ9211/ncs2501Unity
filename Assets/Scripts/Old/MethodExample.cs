using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int parameter1 = 1, parameter2 =2;
        int intMethod = IntMethod(parameter1, parameter2);
        Debug.Log(intMethod);

        float parameter3 = 1.2f;
        voidMethod(parameter3.ToString());
        voidMethod(parameter3);
    }

      int IntMethod(int p1, int p2)
      {
        return ( p1 + p2);
      }
    void voidMethod(string message)
    {
        Debug.Log(message);
        return; //생략 가능
    }

    void voidMethod(float fv) // (string message) 랑 달라서 사용가능
    {
        Debug.Log($"FLOAT:{fv}");
    }
}
