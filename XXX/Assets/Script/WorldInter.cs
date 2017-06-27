using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInter : MonoBehaviour {


    NavMeshAgent playerAg;

     void Start()
    {
        playerAg = GetComponent<NavMeshAgent>();  
    }


    void Update()
    {
      
        if (Input.GetMouseButtonDown(1) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteration();
	}
    void GetInteration()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if(Physics.Raycast(interactionRay, out interactionInfo,Mathf.Infinity))
        {
            GameObject interactedObject = interactionInfo.collider.gameObject;
            if (interactedObject.tag == "Interactable Object")
            {
                interactedObject.GetComponent<Interactable>().MoveToInteraction(playerAg);
            }
            else
            {
                playerAg.stoppingDistance = 0;
                playerAg.destination = interactionInfo.point;
            }
        }
    }
}
