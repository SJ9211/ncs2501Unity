using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    
    void Start()
    {
        //value type
        Vector3 pos = transform.position;
        //Debug.Log($"pos:{pos}");
        pos = new Vector3(0, 2, 0); 
        //Debug.Log($"pos:{pos}");   

        // reference type
        Transform tran = transform;
        tran.position= new Vector3(0, 2, 0);

    }

    void Update()
    {
        
    }
}
