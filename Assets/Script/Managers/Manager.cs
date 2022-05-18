using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //필드
    private static GameObject checkingMng;
    static Manager instance; //유일성을 보장
    //프로퍼티(get, set)
    public static Manager Instance { get { Init(); return instance; } } //외부에서 호출할 때 사용
    //메서드(함수)

    InputManager input = new InputManager();
    public static InputManager Input { get { return Instance.input; } }

    ResourceManager resource = new ResourceManager();
    public static ResourceManager Resource { get { return Instance.resource; } }

    void Start()
    {
        checkingMng = GameObject.Find("Mng");
        Init();
    }

    void Update()
    {
        input.OnUpdate();
    }

    static private void Init()
    {
        if (checkingMng == null)
        {
            if (instance == null)
            {
                GameObject go = GameObject.Find("Mng");
                if (go == null)
                {
                    go = new GameObject { name = "Mng" };
                    go.AddComponent<Manager>();
                }

                DontDestroyOnLoad(go);
                instance = go.GetComponent<Manager>();
            }
        }
    }

}
