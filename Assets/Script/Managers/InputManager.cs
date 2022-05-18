using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Action KeyAction = null; // ������ ��������Ʈ

    public void OnUpdate()
    {
        //InputManger�� �Է��� üũ�� ������ ������ �Է��� ������ �̺�Ʈ�� ����
        if (Input.anyKey == false)
            return;
        if (KeyAction != null)
            KeyAction.Invoke();
    }
}
