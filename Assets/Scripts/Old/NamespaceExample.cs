using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jungse;


public class NamespaceExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NamespaceDefinitionExample.StaticSample();
        // Debug.Log("Name Space");
        var ns = new NamespaceDefinitionExample();
        ns.DebugLog("Namespace");
        
        Debug.Log(GetData(0));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static int GetData(int a)
    {
        return 1;
    }
}
