using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;

    Animator npcAnimation;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        npcAnimation = GetComponent<Animator>();
    }

    void Update()
    {
        nav.SetDestination(target.position);

        Vector3 directionToTarget = target.position - transform.position;
        directionToTarget.y = 0f;
        directionToTarget.Normalize();

        float moveZ = Vector3.Dot(transform.forward, directionToTarget);
        float moveX = Vector3.Dot(transform.right, directionToTarget);

        float speed = nav.velocity.magnitude;

        bool isMoving = speed > 1.5f;
        npcAnimation.SetBool("IsWalking", isMoving);
        npcAnimation.SetBool("IsIdle", !isMoving);

        if (isMoving)
        {
            npcAnimation.SetFloat("MoveX", moveX);
            npcAnimation.SetFloat("MoveZ", moveZ);
        }
        else
        {
            npcAnimation.SetFloat("MoveX", 0f);
            npcAnimation.SetFloat("MoveZ", 0f);
        }
    }
}