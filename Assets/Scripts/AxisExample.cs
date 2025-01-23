using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float hRange;
    public float vRange;
    public TextMeshPro hTextOutput;
    public TextMeshPro vTextOutput;
    public TextMeshPro textOutput;
    
    void Update()
    {
       
        float h = Input.GetAxis("Horizontal");
        // float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float vPos = h * vRange;

        transform.position = new Vector3(xPos, 0, vPos);
        //textOutput.text = "Value Returned:" + h.ToString("F2");
        //textOutput.text = "$Value Returned: {h:F2}";
        hTextOutput.text = "H Returnde: {h:F2}";
        vTextOutput.text = "V Returned: {v:F2}";
    }
}
