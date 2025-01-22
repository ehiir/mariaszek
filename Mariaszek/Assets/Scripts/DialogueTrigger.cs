using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public bool oldPerson = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && oldPerson == true)
        {
            dialogueRunner.StartDialogue("OldPerson");
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "OldPerson")
        {
            oldPerson = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "OldPerson")
        {
            oldPerson = false;
        }
    }
}
