using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponents : MonoBehaviour
{
    private Light myLighe;
    // Start is called before the first frame update
    void Start()
    {
        myLighe = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // GetKeyUp - 누르고 떈후 카운트      GetKeyDown - 누르자마자 카운트
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLighe.enabled = !myLighe.enabled;
            // enabled - 활설화/비활성화
        }
    }
}
