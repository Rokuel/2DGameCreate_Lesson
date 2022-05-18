using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabTest : MonoBehaviour
{
    private GameObject tank;
    void Start()
    {
        tank = Manager.Resource.Instantiate("Tank");
        Manager.Resource.Destroy(tank, 3f);
        
    }

    void Update()
    {
        
    }
}
