using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tracker : MonoBehaviour {
    public GameObject FoxHolder;
    public GameObject FoxFront;
    public GameObject cameraRig;
    private NavMeshAgent agent; // tracker
    public Transform target; // traget 
    
    // Use this for initialization
    void Start () {
        agent = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		if (agent != null)
        {
            agent.SetDestination(target.position);
        }
        if (transform.name =="FoxHolder")
        {
            if (Vector3.Distance(transform.position, target.transform.position)<1)
            {
                FoxHolder.GetComponent<Tracker>().enabled = false;
                FoxHolder.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
                cameraRig.transform.position = FoxFront.transform.position;
            }
        }
	}

    
}
