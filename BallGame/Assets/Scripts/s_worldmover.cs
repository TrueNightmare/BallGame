using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_worldmover : MonoBehaviour
{
    [Header("Degree Limits")]
    public float MaxX = 35;
    public float MaxZ = 35;

    float x;
    float z;
    private Quaternion Euler;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = Input.GetAxis("Horizontal") * MaxX;
        z = Input.GetAxis("Vertical") * MaxZ;

        Euler = Quaternion.Euler(x, 0, z);

        if (Input.GetButton("Horizontal") && GameManager.Instance.CanPlayerMove || Input.GetButton("Vertical") && GameManager.Instance.CanPlayerMove)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Euler, Time.deltaTime * 2);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * 2);
        }
    }
}
