using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class cubeinteract : MonoBehaviour
{
   RaycastHit HitInfo;
   public DialogueRunner dialogueRunner;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dialogueRunner.StartDialogue("char1");
        }

    }
}
