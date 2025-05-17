using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotMoveController : MonoBehaviour
{
    public GameObject[] destinations;
    private NavMeshAgent agent;
    private int currentPointIndex;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(destinations[0].transform.position);
    }



   public void nextPoint()
    {
        
        if (currentPointIndex < destinations.Length - 1)
        {
            currentPointIndex++;
            agent.SetDestination(destinations[currentPointIndex].transform.position);
            
        }
        else
        {
            currentPointIndex = 0;
        }
    }
    
}