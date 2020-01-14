using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //Variables Not seen in inspector
    public enum Colour { Red, Blue, Green, Yellow }
    bool CanSwitch = true;
    Color color;
    Renderer MaterialRenderer;

    //for floating
    Vector3 OffsetPoint;

    [Header("Required Information")]
    public Colour colour;
    public float SecondsToWait = 2.0f;
    public bool AllowReset = true;

    public float RotationSpeed = 50f;

    void Start()
    {
        MaterialRenderer = GetComponent<Renderer>();
        OffsetPoint = transform.localPosition;

        switch (colour)
        {
            case Colour.Red:
                color = Color.red;
                break;
            case Colour.Blue:
                color = Color.blue;
                break;
            case Colour.Green:
                color = Color.green;
                break;
            case Colour.Yellow:
                color = Color.yellow;
                break;
            default:
                break;
        }

        MaterialRenderer.material.SetColor("_Color", color);
        MaterialRenderer.material.SetColor("_EmissionColor", color);
    }

    void FixedUpdate()
    {
        transform.Rotate(0, RotationSpeed * Time.deltaTime, 0);

        var TempPos = OffsetPoint;
        TempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI) * 0.2f;
        transform.localPosition = TempPos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && CanSwitch)
        {
            GameManager.Instance.ChangeLockedState((int)colour);
            if (AllowReset)
            {
                StartCoroutine(WaitTime());
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    IEnumerator WaitTime()
    {
        CanSwitch = false;
        yield return new WaitForSeconds(SecondsToWait);
        CanSwitch = true;
    }
}
