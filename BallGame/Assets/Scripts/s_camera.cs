using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_camera : MonoBehaviour
{
    [Header("View Options")]
    public GameObject ViewTarget;
    public bool FollowTarget;

    public Vector3 Differnce;
    [Header("Rotation Options")]
    public bool Rotation;
    public float Limit;


    [Tooltip("View Target as pivot point, useless if FollowTarget is enabled")]
    public bool LookAtTarget;

    float x;
    float z;

    Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        //Differnce = transform.position - ViewTarget.transform.position;

        x = -Input.GetAxis("Vertical");
        z = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (FollowTarget)
        {
            transform.position = new Vector3(ViewTarget.transform.position.x + Differnce.x,
                ViewTarget.transform.position.y + Differnce.y,
                ViewTarget.transform.position.z + Differnce.z);
        }

        if (LookAtTarget)
        {
            transform.LookAt(ViewTarget.transform);
        }

        if (Rotation)
        {

        }
    }
}
