using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObjects : MonoBehaviour
{
    
    void Start()
    {
        gameObject.SetActive(false);
        //float x =transform.position.x;  <- 이걸로도 쓸수있음
    }

}
