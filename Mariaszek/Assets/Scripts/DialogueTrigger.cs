using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public bool oldPerson = false;
    public bool dog = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && oldPerson == true)
        {
            dialogueRunner.StartDialogue("OldPerson");
        }

        if (Input.GetKeyDown(KeyCode.E) && dog == true)
        {
            Debug.Log("Gadasz z psem pojebie");
            // dialogueRunner.StartDialogue("Dog");
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "OldPerson")
        {
            oldPerson = true;
        }

        if (other.tag == "Dog")
        {
            dog = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "OldPerson")
        {
            oldPerson = false;
        }

        if (other.tag == "Dog")
        {
            dog = false;
        }
    }
}
