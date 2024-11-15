using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class actionTrigger : MonoBehaviour
{
    [SerializeField] private sceneAction sceneAction = null;

    private Collider hitbox;
    private Vector2 hitpoint;


    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sceneAction.GetActionIcon();
        hitbox = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        
        {
            sceneAction.Interact();
            this.gameObject.SetActive(false);
        }
    }
}
