using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CamerMovementController : MonoBehaviour {

    public static CamerMovementController instance;
    public GameObject CameraRig;
    public Transform target;
    public GameObject rabbit;
    public GameObject fox;
    public GameObject bear;
    public GameObject dragon;
    public GameObject CameraEye;
    public GameObject thisGameobject;
    public GameObject cameraParent;
    bool firstEnter = false;

                                                                     
   
    // Use this for initialization
    void Awake()                      
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {


        if (thisGameobject != null )
        {
            if (thisGameobject.name == "FoxHolder")
            {
                target = rabbit.transform.Find("point");
                target.transform.position = new Vector3(rabbit.transform.position.x, Mathf.Abs(rabbit.transform.position.y + 0.269f), rabbit.transform.position.z + 0.2518f);
                if (Vector3.Distance(thisGameobject.transform.position, target.position) < 3)
                {
                    
                    thisGameobject.transform.GetComponent<NavMeshAgent>().enabled = false;
                    thisGameobject.transform.GetComponent<FindTarget>().enabled = false;

                    cameraParent.transform.position = new Vector3(fox.transform.position.x, Mathf.Abs(fox.transform.position.y + 1.057f), fox.transform.position.z + 1.282f);
                   
                    bear.GetComponent<FindTarget>().enabled = true;

                    rabbit.gameObject.SetActive(false);
                    Destroy(rabbit.gameObject);

                    thisGameobject.transform.GetComponent<FollowManager>().enabled = true;
                    thisGameobject.transform.GetComponent<FollowManager>().speed = 20f;

                }
            }

            if (thisGameobject.name == "BearHolder")
            {
                target = fox.transform.Find("point");
                target.transform.position = new Vector3(fox.transform.position.x + 0.0232f, Mathf.Abs(fox.transform.position.y + 1.5161f), fox.transform.position.z + 1.2517f);

                if (Vector3.Distance(thisGameobject.transform.position, target.position) < 3)
                {
                    thisGameobject.transform.GetComponent<NavMeshAgent>().enabled = false;
                    thisGameobject.transform.GetComponent<FindTarget>().enabled = false;

                    cameraParent.transform.position = new Vector3(bear.transform.position.x + 0.0229f, Mathf.Abs(bear.transform.position.y + 1.1745f), bear.transform.position.z + 2.0101f);

                    dragon.GetComponent<FindTarget>().enabled = true;
                    Destroy(fox.gameObject);

                    thisGameobject.transform.GetComponent<FollowManager>().enabled = true;
                    thisGameobject.transform.GetComponent<FollowManager>().speed = 20f;
                }
            }

            if (bear != null)
            {
                if (thisGameobject.name == "DragonHolder")
                {
                    target = bear.transform.Find("point");
                    target.transform.position = new Vector3(bear.transform.position.x + 0.0655f, Mathf.Abs(bear.transform.position.y + 0.9124f), bear.transform.position.z + 1.496f);
                    if (Vector3.Distance(thisGameobject.transform.position, target.position) < 3)
                    {
                        thisGameobject.transform.GetComponent<NavMeshAgent>().enabled = false;
                        thisGameobject.transform.GetComponent<FindTarget>().enabled = false;
      
                        cameraParent.transform.position = new Vector3(dragon.transform.position.x + 0.007f, Mathf.Abs(dragon.transform.position.y + 5.24f), dragon.transform.position.z + 10.03f);
                        Destroy(bear.gameObject);


                        thisGameobject.transform.GetComponent<FollowManager>().enabled = true;
                        thisGameobject.transform.GetComponent<FollowManager>().speed = 20f;
                    }
                }
            }
                   
        }
    }
}
