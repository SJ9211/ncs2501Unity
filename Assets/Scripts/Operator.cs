using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
