using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    // Start is called before the first frame update
    void old()
    {
        List<int> list = new List<int>();
        int intSize = sizeof(int);
        int fSize = sizeof(float);
        int bSize = sizeof(bool);

        Debug.Log($"int:{intSize}, float{fSize}");

        int i = 1;
        Debug.Log($"before:{i}");
        Debug.Log($"++i:{++i}");
        Debug.Log($"after:{i}");

        i = 1;
        Debug.Log($"before:{i}");
        Debug.Log($"++i:{++i}");
        Debug.Log($"after:{i}");

        for (int k = 0; k < 10; k ++)
        {

        }
    }
    void Start()
        {
        int a = 0, b = 1;
        if (a != b)
            Debug.Log("같지 않다");
        else
            Debug.Log("같다");
      //////////////////////////////
        if (!(a == b))
             Debug.Log("같지 않다");
        else    
              Debug.Log("같다");
   
        char c1 = 'a';
        char c2 = 'A';
        Debug.Log (c1 == c2);

         // 같음 연산자 == , !=
        a = 1 + 1 + 2 + 3;
        b = 6;
        Debug.Log(a !=b);
        Debug.Log(a.Equals(b));
        Debug.Log(!a.Equals(b));

        // is 연산자
        int i = 1;
        object iBoxed = i;
        Debug.Log((iBoxed is int).ToString());
        Debug.Log((iBoxed is float).ToString());


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
