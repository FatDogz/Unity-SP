using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {
  [HideInInspector]

    public NavMeshAgent playerAg;
    private bool hasInteracted;

    public virtual void MoveToInteraction(NavMeshAgent playerAg)
    {
        hasInteracted = false;
        this.playerAg = playerAg;
        playerAg.stoppingDistance = 3f;
        playerAg.destination = transform.position;

        
    }
     void Update()
    {
        if ( !hasInteracted && playerAg !=null && !playerAg.pathPending)
        {
            if(playerAg.remainingDistance <= playerAg.stoppingDistance)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base class.");
    }
}
