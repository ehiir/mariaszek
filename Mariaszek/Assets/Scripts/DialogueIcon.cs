using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueIcon : MonoBehaviour
{
    public GameObject icon;

    void Start()
    {
        icon.SetActive(false);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            icon.SetActive(true);
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            icon.SetActive(false);
        }
    }
}
