using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_worldmover : MonoBehaviour
{

    [Header("Required Settings")]
    public GameObject Player;
    GameObject Level;

    [Header("Degree Limits")]
    public float MaxX = 35;
    public float MaxZ = 35;

    float x;
    float z;
    private Quaternion Euler;    

    Vector3 LastLocation;
    float DifferenceX;
    float DifferenceZ;
    float DifferenceY;

    float PlayerYDifference;

    private void Awake()
    {
        Level = transform.GetChild(0).gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        LastLocation = transform.position;
        PlayerYDifference = Player.transform.position.y - transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //x = Input.GetAxis("Horizontal") * MaxX;
        //z = Input.GetAxis("Vertical") * MaxZ;

        //Euler = Quaternion.Euler(x, 0, z);

        //if (Input.GetButton("Horizontal") && GameManager.Instance.CanPlayerMove || Input.GetButton("Vertical") && GameManager.Instance.CanPlayerMove)
        //{
        //    transform.rotation = Quaternion.Lerp(transform.rotation, Euler, Time.deltaTime * 2);
        //}
        //else
        //{
        //    transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, Time.deltaTime * 2);
        //}

        //transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 2, Player.transform.position.z);
        UpdateLevelLocation();
    }

    void UpdateLevelLocation()
    {
        //DifferenceX = LastLocation.x - transform.position.x;
        //DifferenceZ = LastLocation.z - transform.position.z;
        //DifferenceY = LastLocation.y - transform.position.y;

        //LastLocation = transform.position;

        //Level.transform.localPosition += new Vector3(DifferenceX, DifferenceY, DifferenceZ);

        //transform.RotateAround(Player.transform.position, new Vector3(x,0,z), (x + z) / 2);
    }
}
