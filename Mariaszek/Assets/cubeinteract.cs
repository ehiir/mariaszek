using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CubeInteract : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    private bool isPlayerNearby = false; // Track if player is near

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isPlayerNearby)
        {
            dialogueRunner.StartDialogue("char1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure the player has the "Player" tag
        {
            isPlayerNearby = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
        }
    }
}