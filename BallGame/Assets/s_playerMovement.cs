using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_playerMovement : MonoBehaviour
{
    [Header("Settings")]
    public float Speed;

    float x;
    float z;
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.Instance.CanPlayerMove)
        {
            x = -Input.GetAxis("Vertical") * Speed;
            z = Input.GetAxis("Horizontal") * Speed;

            rigidbody.AddForce(new Vector3(x, 0, z));
        }
    }
}
