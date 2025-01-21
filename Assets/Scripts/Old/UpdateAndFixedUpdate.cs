using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    // FiexdUpdate 특수한 경우에만 사용 (엔진에 의해 돌아가는 경우)
    void FixedUpdate()
    {
        Debug.Log($"FixedUpdate time:{Time.deltaTime}");
        //Debug.Log("FixedUpdate time:" + Time.deltaTime);
    }

    // 대부분 Update 만 사용
    void Update()
    {
        Debug.Log($"Update time:{Time.deltaTime}");
        //Debug.Log("Update time:" + Time.deltaTime);
    }
}
