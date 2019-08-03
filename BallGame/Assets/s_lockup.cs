using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_lockup : MonoBehaviour
{
    public bool Locked;

    public Material LockUp;
    public Material Clear;

    public Color Colour;

    BoxCollider BoxCollider;

    Renderer Renderer;

    void Awake()
    {
        Renderer = GetComponent<Renderer>();
        BoxCollider = GetComponent<BoxCollider>();

        LockUp.color = Colour;
        Clear.color = Colour;
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Locked)
        {
            Renderer.material = LockUp;
            BoxCollider.enabled = true;
        }
        else
        {
            Renderer.material = Clear;
            BoxCollider.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeState()
    {
        Locked = !Locked;

        if (Locked)
        {
            Renderer.material = LockUp;
            Renderer.material.SetColor("_Color", Colour);
            BoxCollider.enabled = true;
        }
        else
        {
            Renderer.material = Clear;
            Renderer.material.SetColor("_Color", Colour);
            BoxCollider.enabled = false;
        }
    }
}
