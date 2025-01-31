using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barreIend;
    
    void Update()
    {
        if ( Input.GetButtonDown("Firel"))
        {
            Rigidbody rocketIstance;
            rocketIstance = Instantiate(rocketPrefab,
             barreIend.position, barreIend.rotation)
             as Rigidbody;
             rocketIstance.AddForce(barreIend.forward * 5000);
             
        }
    }
}
