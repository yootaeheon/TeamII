using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody rb;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * moveSpeed, ForceMode.Impulse);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * moveSpeed, ForceMode.Impulse);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * moveSpeed, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * moveSpeed, ForceMode.Impulse);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * moveSpeed, ForceMode.Impulse);
        }
    }
}
