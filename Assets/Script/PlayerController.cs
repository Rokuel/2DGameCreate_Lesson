using System.Collections;
using System.Collections.Generic;
using UnityEngine;


struct MyVector
{
    public float x;
    public float y;
    public float z;

    public MyVector(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static MyVector operator +(MyVector a, MyVector b)
    {
        return new MyVector(a.x + b.x, a.y+b.y, a.z+b.z);
    }
    public static MyVector operator -(MyVector a, MyVector b)
    {
        return new MyVector(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public float magnitude
    {
        get { return Mathf.Sqrt(x * x + y * y + z * z); }
    }
    public MyVector normalized
    {
        get { return new MyVector(x / magnitude, y / magnitude, z / magnitude); }
    }
}

public class PlayerController : MonoBehaviour
{
    [SerializeField] float Speed = 2f;

    void Start()
    {
        Manager.Input.KeyAction -= OnKeyboard;
        Manager.Input.KeyAction += OnKeyboard; //구독신청
        //MyVector pos = new MyVector(0f, 10f, 0f);
        //pos += new MyVector(0f, 1f, 0f);

        //MyVector a = new MyVector(5f, 0f, 0f);
        //MyVector b = new MyVector(10f, 0f, 0f);
        //MyVector dir = b - a;
        //dir = dir.normalized;

    }

    void Update()
    {
        //float scroll = Input.GetAxis("Mouse ScrollWheel") * Speed;
        //cam.fieldOfView += scroll;


    }
    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.1f);
            transform.position += Vector3.forward * Time.deltaTime * Speed;
            //transform.rotation = Quaternion.LookRotation(Vector3.forward);
            //transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.1f);
            transform.position += Vector3.back * Time.deltaTime * Speed;
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            //transform.Translate(Vector3.back * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.1f);
            transform.position += Vector3.left * Time.deltaTime * Speed;
            //transform.rotation = Quaternion.LookRotation(Vector3.left);
            //transform.Translate(Vector3.left * Time.deltaTime * Speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.1f);
            transform.position += Vector3.right * Time.deltaTime * Speed;
            //transform.rotation = Quaternion.LookRotation(Vector3.right);
            //transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
    }
}
