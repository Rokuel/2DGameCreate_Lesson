using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) // �浹 �� �ѹ�
    {
        Debug.Log("OnCollisionEnter" + collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision) // �浹 �� ���
    {
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision) // �浹 �����
    {
        Debug.Log("OnCollisionExit");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
}
