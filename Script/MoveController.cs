using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour {
    SteamVR_TrackedObject steamVR_TrackedObject;
    SteamVR_Controller.Device device;
	// Use this for initialization
	void Start () {
        steamVR_TrackedObject = GetComponent<SteamVR_TrackedObject>();
        device = SteamVR_Controller.Input((int)steamVR_TrackedObject.index);
    }
	
	// Update is called once per frame
	void Update () {
        if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("OK");
        }
	}
}
