using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class StandardDateTime : MonoBehaviour
{
   
    void Start()
    {
        DateTime dt = new DateTime(2025 , 1 , 22, 13,24,35);

        Debug.Log(dt.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "한국 {0:d}", dt));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),
        $"korea {dt:d}"));

        Debug.Log(dt.ToString("D", CultureInfo.CreateSpecificCulture("ja-JP")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "{0:D}", dt));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),
         $"korea {dt:D}"));

        Debug.Log(dt.ToString("D", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "{0:f}", dt));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),
         $"korea {dt:f}"));

        Debug.Log(dt.ToString("D", CultureInfo.CreateSpecificCulture("en-US")));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"), "{0:y}", dt));
        Debug.Log(string.Format(CultureInfo.CreateSpecificCulture("ko-KR"),
         $"korea {dt:y}"));

        Debug.Log(string.Format("{0:yyyyMMdd_HHmmss}", dt));
        Debug.Log($"{dt:yyyyMMdd_HHmmss}");
        Debug.Log($"{dt:d}   {dt:ddd}");
    }


    
    void Update()
    {
        
    }
}
