using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    BoxCollider[] BoxColliders;

    public GameObject WinScreen;
    public Canvas HUD;
    // Start is called before the first frame update
    void Start()
    {
        BoxColliders = GetComponents<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.instance.Play("Win");
            GameManager.Instance.CanPlayerMove = false;
            GameManager.Instance.Timer.SetActive(false);
            WinScreen.GetComponent<Canvas>().enabled = true;
            WinScreen.GetComponent<EndScreen>().UpdateScore();
            HUD.enabled = false;
            BoxColliders[1].enabled = false;
        }
    }
}
