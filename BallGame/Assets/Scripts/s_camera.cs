using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_camera : MonoBehaviour
{
    public GameObject ViewTarget;
    public bool FollowTarget;

    public Vector3 Differnce;

    [Tooltip("View Target as pivot point, useless if FollowTarget is enabled")]
    public bool LookAtTarget;

    // Start is called before the first frame update
    void Start()
    {
        //Differnce = transform.position - ViewTarget.transform.position;
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
    }
}
