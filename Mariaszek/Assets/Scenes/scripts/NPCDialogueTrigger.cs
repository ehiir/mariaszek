using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NPCDialogueTrigger : MonoBehaviour
{
    public float detectionRange = 5f; // Maximum distance to detect NPCs
    private PlayerMovement playerMovement; // Reference to the player's movement script
    private DialogueRunner dialogueRunner; // Reference to the Yarn Spinner DialogueRunner

    private void Start()
    {
        // Get reference to the DialogueRunner in the scene
        dialogueRunner = FindObjectOfType<DialogueRunner>();
        // Get reference to the player's movement script (assuming it's on the same GameObject)
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        // Check if SPACE key is pressed and DialogueRunner is not currently in a conversation
        if (Input.GetKeyDown(KeyCode.Space) && !dialogueRunner.IsDialogueRunning)
        {
            // Find the nearest NPC
            GameObject nearestNPC = FindNearestNPC();

            // If an NPC was found
            if (nearestNPC != null)
            {
                // Get the NPC's dialogue node name
                NPC npcScript = nearestNPC.GetComponent<NPC>();
                if (npcScript != null && !string.IsNullOrEmpty(npcScript.dialogueNode))
                {
                    // Start the dialogue with the NPC's dialogue node
                    dialogueRunner.StartDialogue(npcScript.dialogueNode);

                    // Disable player movement
                    if (playerMovement != null)
                    {
                        playerMovement.enabled = false;
                    }
                }
            }
        }
    }

    // Finds the nearest NPC within a given range
    private GameObject FindNearestNPC()
    {
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC"); // NPCs should be tagged as "NPC"
        GameObject nearestNPC = null;
        float shortestDistance = detectionRange;

        foreach (GameObject npc in npcs)
        {
            float distance = Vector3.Distance(transform.position, npc.transform.position);
            if (distance < shortestDistance)
            {
                nearestNPC = npc;
                shortestDistance = distance;
            }
        }

        return nearestNPC;
    }

    // Re-enable player movement after dialogue ends
    public void OnDialogueEnd()
    {
        if (playerMovement != null)
        {
            playerMovement.enabled = true;
        }
    }
    private void Start()
{
    dialogueRunner = FindObjectOfType<DialogueRunner>();
    playerMovement = GetComponent<PlayerMovement>();

    // Subscribe to dialogue completion event
    dialogueRunner.onDialogueComplete.AddListener(OnDialogueEnd);
}
}
