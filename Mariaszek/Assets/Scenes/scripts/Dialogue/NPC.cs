using UnityEngine;
using Yarn.Unity;

/// <summary>
/// Attached to non-player characters (NPCs) and stores the name of the Yarn
/// node that should be run when you talk to them.
/// </summary>
public class NPC : MonoBehaviour
{
    [Header("Character Settings")]
    public string characterName = ""; // Name of the NPC.

    public string talkToNode = ""; // The Yarn node to run when interacting.

    [Header("Optional")]
    public YarnProgram scriptToLoad; // Yarn script to load at runtime.

    void Start()
    {
        if (scriptToLoad != null)
        {
            // Find the DialogueRunner in the scene.
            var dialogueRunner = FindObjectOfType<DialogueRunner>();
            if (dialogueRunner != null)
            {
                // Add the script to the DialogueRunner.
                dialogueRunner.Add(scriptToLoad);
            }
            else
            {
                Debug.LogWarning("No DialogueRunner found in the scene. The Yarn script will not be added.");
            }
        }
    }
}

