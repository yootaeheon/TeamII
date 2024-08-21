using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public int movePower;
    public Rigidbody rigid;

    private void Start()
    {
        rigid.AddForce(Vector3.up * movePower, ForceMode.Impulse);
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(Vector3.left * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(Vector3.right * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(Vector3.forward * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(Vector3.back * movePower, ForceMode.Force);
        }
    }
}
