using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    private GameObject go;

    public T Load <T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }
    
    public GameObject Instantiate(string path, Transform parent = null)
    {
        GameObject go = Load<GameObject>($"Prefabs/{path}");
        if(go == null)
        {
            Debug.LogWarning("Failed to load Prefab");
            return null;
        }
        return Object.Instantiate(go, parent);
    }

    public void Destroy ( GameObject go, float t = 0.0f )
    {
        if( go ==  null )
        {
            return;
        }

        Object.Destroy( go, t );
    }
}
