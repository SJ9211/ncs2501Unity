using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using JetBrains.Annotations;
public class VariableType : MonoBehaviour
{

    //  필드
    static public bool statcivariable = true; // 정적 변수
    private int m_GlobalVariable = 5; // 전역 변수
   // public int abCde = 5;  // 유니티 에디터에서 보여진다
    public string STR = "hello";

    const float pi = 3.14f;

    void Start()
    {

        int localVariabl = 1; // 지역 변수
        int localVariable2;
        //Debug.Log(localVariable2.ToString());
        localVariable(1/* 매개변수 */);
        //Debug.Log("abcde:" + abCde);
        //Debug.Log(STR);
        const float pi = 3.14f;
        float npi = pi + 10;

    }
    void localVariable(int parameter/*매개 변수*/)
    {
        float localVariable = parameter; // 지역 변수
    }
    void TimeSpanExample()
    {
    
     
      DateTime dt1 = new DateTime(2018,8,1,2,3,4);
      DateTime dt2 = new DateTime(2019,10,20,12,0,5);

      TimeSpan ts = dt2 - dt1 ;

      Debug.Log(ts.Days.ToString());
      Debug.Log(ts.Hours.ToString());
      Debug.Log(ts.Minutes.ToString());
      Debug.Log(ts.Seconds.ToString());

      Debug.Log(ts.TotalHours.ToString());
      Debug.Log(ts.TotalMinutes.ToString());
    
     //Stopwatch sw = new Stopwatch();

    }
 }
