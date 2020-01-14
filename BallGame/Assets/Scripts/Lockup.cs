using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lockup : MonoBehaviour
{
    [Header("Setup")]
    public Material Locked;
    public Material Unlocked;

    BoxCollider boxCollider;
    Renderer MaterialRenderer;

    public enum Colour { Red, Blue, Green, Yellow}
    public Colour colour;

    Color ObjectColour;

    void Awake()
    {
        boxCollider = GetComponent<BoxCollider>();
        MaterialRenderer = GetComponent<Renderer>();

        switch (colour)
        {
            case Colour.Red:
                Locked.color = Color.red;
                Unlocked.color = Color.red;
                ObjectColour = Color.red;
                break;

            case Colour.Blue:
                Locked.color = Color.blue;
                Unlocked.color = Color.blue;
                ObjectColour = Color.blue;
                break;

            case Colour.Green:
                Locked.color = Color.green;
                Unlocked.color = Color.green;
                ObjectColour = Color.green;
                break;

            case Colour.Yellow:
                Locked.color = Color.yellow;
                Unlocked.color = Color.yellow;
                ObjectColour = Color.yellow;
                break;

            default:
                Locked.color = Color.black;
                Unlocked.color = Color.black;
                ObjectColour = Color.black;
                break;
        }
    }

    void FixedUpdate()
    {
        switch (colour)
        {
            case Colour.Red:
                ChangeState(GameManager.Instance.RedLocked);
                break;
            case Colour.Blue:
                ChangeState(GameManager.Instance.BlueLocked);
                break;
            case Colour.Green:
                ChangeState(GameManager.Instance.GreenLocked);
                break;
            case Colour.Yellow:
                ChangeState(GameManager.Instance.YellowLocked);
                break;
            default:
                break;
        }
    }

    public void ChangeState(bool Lock)
    {
        if (Lock)
        {
            MaterialRenderer.material = Locked;
            MaterialRenderer.material.SetColor("_Color", ObjectColour);
            boxCollider.enabled = true;
        }
        else
        {
            MaterialRenderer.material = Unlocked;
            MaterialRenderer.material.SetColor("_Color", ObjectColour);
            boxCollider.enabled = false;
        }
    }
}
