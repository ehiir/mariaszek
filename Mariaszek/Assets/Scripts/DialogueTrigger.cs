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
    public bool car = false;
    public bool sign = false;
    public bool oldpath = false;
    public bool podmechanikiem = false;
    public bool hotelowner = false;
    public bool swinka = false;
    public bool ogrodnik = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && oldPerson == true)
        {
            dialogueRunner.StartDialogue("OldPerson");
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

        if (Input.GetKeyDown(KeyCode.E) && car == true)
        {
           dialogueRunner.StartDialogue("car");
        }

        if (Input.GetKeyDown(KeyCode.E) && sign == true)
        {
           dialogueRunner.StartDialogue("sign");
        }

        if (Input.GetKeyDown(KeyCode.E) && oldpath == true)
        {
           dialogueRunner.StartDialogue("oldpath");
        }

        if (Input.GetKeyDown(KeyCode.E) && podmechanikiem == true)
        {
           dialogueRunner.StartDialogue("podmechanikiem");
        }

        if (Input.GetKeyDown(KeyCode.E) && hotelowner == true)
        {
           dialogueRunner.StartDialogue("hotelowner_ext");
        }

        if (Input.GetKeyDown(KeyCode.E) && swinka == true)
        {
           dialogueRunner.StartDialogue("swinkawstodole");
        }

        if (Input.GetKeyDown(KeyCode.E) && ogrodnik == true)
        {
           dialogueRunner.StartDialogue("Ogrodnik");
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "OldPerson")
        {
            oldPerson = true;
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

        if (other.tag == "Car")
        {
            car = true;
        }

        if (other.tag == "Sign")
        {
            sign = true;
        }

        if (other.tag == "Oldpath")
        {
            oldpath = true;
        }

        if (other.tag == "Podmechanikiem")
        {
            podmechanikiem = true;
        }

        if (other.tag == "Hotelowner")
        {
            hotelowner = true;
        }

        if (other.tag == "Swinka")
        {
            swinka = true;
        }

        if (other.tag == "Ogrodnik")
        {
            ogrodnik = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "OldPerson")
        {
            oldPerson = false;
        }

        if (other.tag == "Mareczek")
        {
            mareczek = false;
        }

        if (other.tag == "Detektyw")
        {
            detektyw = false;
        }

        if (other.tag == "Tarociara")
        {
            tarociara = false;
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

        if (other.tag == "Car")
        {
            car = false;
        }

        if (other.tag == "Sign")
        {
            sign = false;
        }
        
        if (other.tag == "Oldpath")
        {
            oldpath = false;
        }

        if (other.tag == "Podmechanikiem")
        {
            podmechanikiem = false;
        }

        if (other.tag == "Hotelowner")
        {
            hotelowner = false;
        }
         
        if (other.tag == "Swinka")
        {
            swinka = false;
        }

        if (other.tag == "Ogrodnik")
        {
            ogrodnik = false;
        }
    }
}
