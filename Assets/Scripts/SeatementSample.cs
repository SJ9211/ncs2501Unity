using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SeatementSample : MonoBehaviour
{
    enum EAvengers { IronMan, SpiderMan, Hulk};
    void Start()
    {
        EAvengers avengers = EAvengers.SpiderMan;
        switch (avengers)
        {
            case EAvengers.IronMan:
                Debug.Log(avengers);
                break;
            case EAvengers.SpiderMan:
                Debug.Log(avengers.ToSafeString());
                break;
            case EAvengers.Hulk:
                Debug.Log(avengers);
                break;
            default:
                Debug.Log("no avengers");
                break;

                if (avengers == EAvengers.IronMan)
                {
                    Debug.Log(avengers);
                }
                else if (avengers == EAvengers.SpiderMan)
                {
                    Debug.Log(avengers.ToSafeString());
                }
                else if (avengers == EAvengers.Hulk)
                {
                    Debug.Log(avengers);
                }
                else
                {
                    Debug.Log("no averngers");
                }
        }



        //     int i1 = 1, i2 = 2 ;
        //     if (i1< i2)
        //     {
        //     Debug.Log("It's true.");
        //     }
        //     else if ( i1 > i2 )
        //     {
        //         // 오타 에러 수정 ( by JS92)
        //         //Debuh.Log("...");
        //         Debug.Log("...");
        //     }
        //     else
        //     {
        //         Debug.Log("False.");
        //     }
    }
}