using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    //�ʵ�
    private static GameObject checkingMng;
    static Manager instance; //���ϼ��� ����
    //������Ƽ(get, set)
    public static Manager Instance { get { Init(); return instance; } } //�ܺο��� ȣ���� �� ���
    //�޼���(�Լ�)

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
