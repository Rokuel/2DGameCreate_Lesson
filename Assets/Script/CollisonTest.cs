using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) // 충돌 시 한번
    {
        Debug.Log("OnCollisionEnter" + collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision) // 충돌 중 계속
    {
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision) // 충돌 벗어나면
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
