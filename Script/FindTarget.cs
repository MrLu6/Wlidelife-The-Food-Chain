using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindTarget : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    // Use this for initialization
    void Start()
    {
        CamerMovementController.instance.thisGameobject = transform.gameObject;
        agent = transform.GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        if (agent != null)
        {
            agent.SetDestination(target.position);
        }

    }
}
