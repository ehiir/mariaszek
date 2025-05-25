using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    public bool oldPerson = false;
    public bool dog = false;
    public bool mareczek = false;
    public bool detektyw = false;
    public bool tarociara = false;
    public bool ardenia = false;
    public bool hotelowner2 = false;
    public bool kanapka = false;

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

        if (Input.GetKeyDown(KeyCode.E) && mareczek == true)
        {
           dialogueRunner.StartDialogue("Mareczek");
        }

        if (Input.GetKeyDown(KeyCode.E) && detektyw == true)
        {
           dialogueRunner.StartDialogue("Detektyw");
        }

        if (Input.GetKeyDown(KeyCode.E) && tarociara == true)
        {
           dialogueRunner.StartDialogue("staratarociara");
        }

        if (Input.GetKeyDown(KeyCode.E) && ardenia == true)
        {
           dialogueRunner.StartDialogue("Ardenia");
        }

        if (Input.GetKeyDown(KeyCode.E) && hotelowner2 == true)
        {
           dialogueRunner.StartDialogue("hotelowner_int");
        }

        if (Input.GetKeyDown(KeyCode.E) && kanapka == true)
        {
           dialogueRunner.StartDialogue("kanapka");
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

        if (other.tag == "Mareczek")
        {
            mareczek = true;
        }

        if (other.tag == "Detektyw")
        {
            detektyw = true;
        }

         if (other.tag == "Tarociara")
        {
            tarociara = true;
        }

         if (other.tag == "Ardenia")
        {
            ardenia = true;
        }

         if (other.tag == "Hotelowner2")
        {
            hotelowner2 = true;
        }
        
         if (other.tag == "Kanapka")
        {
            kanapka = true;
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

          if (other.tag == "Mareczek")
        {
            mareczek = false;
        }

        if (other.tag == "Detektyw")
        {
            detektyw = false;
        }

          if (other.tag == "Ardenia")
        {
            ardenia = false;
        }

          if (other.tag == "Hotelowner2")
        {
            hotelowner2 = false;
        }

         if (other.tag == "Kanapka")
        {
            kanapka = false;
        }
    }
}
