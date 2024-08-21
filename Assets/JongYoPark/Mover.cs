using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    public int movePower;
    public Rigidbody rigid;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigid.AddForce(Vector3.left * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid.AddForce(Vector3.right * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.AddForce(Vector3.forward * movePower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigid.AddForce(Vector3.back * movePower, ForceMode.Force);
        }
    }
}
