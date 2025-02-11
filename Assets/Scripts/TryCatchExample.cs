using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatchExample : MonoBehaviour
{

    GameObject go;
    void Start()
    {
        //go = new GameObject();

        try
        {
            Debug.Log(go.name);
        }
        catch (DivideByZeroException dz)
        {
            Debug.Log($"나누기 0 예외:{dz}");
        }
        catch (IndexOutOfRangeException ne)
        {
            Debug.LogWarning($"IOR ~발생 : {ne}");
        }
        // Exception 은 마지막에 쓴다
        catch (Exception ex)
        {
            Debug.LogWarning($"예외 발생 !!! : {ex}");
        }
        // 위에 catch가 없고 에러나는 상황이면 실행 안됌
        Debug.Log("끝");
    }

}
