using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStats : MonoBehaviour
{
    public GameObject myObject;
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }  
}
