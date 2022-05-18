using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action KeyAction = null; // 일종의 델리게이트

    public void OnUpdate()
    {
        //InputManger가 입력을 체크한 다음에 실제로 입력이 있으면 이벤트로 전파
        if (Input.anyKey == false)
            return;
        if (KeyAction != null)
            KeyAction.Invoke();
    }
}
