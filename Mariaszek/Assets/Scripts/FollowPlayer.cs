using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;
    float npcSpeed;

    // Animator npcAnimation;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        
        // npcAnimation = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        nav.SetDestination(target.position);

        if (nav.velocity.magnitude > 0.5f)  
        {
            Debug.Log("NPC is walking");

            // npcAnimation.SetBool("IsWalking", true);  
            // npcAnimation.SetBool("IsIdle", false);   
        }

        else
        {
            Debug.Log("NPC is idle");

            // npcAnimation.SetBool("IsWalking", false);  
            // npcAnimation.SetBool("IsIdle", true);      
        }
    }
}
