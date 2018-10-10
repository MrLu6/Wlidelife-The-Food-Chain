using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowManager : MonoBehaviour
{
    /// <summary>
    
    /// </summary>
    public GameObject _target;
    public GameObject CameraEye;

    public float _height;

    public float _distance;
    public float speed = 0;
    Vector3 _pos;
    // Use this for initialization
    void Start()
    {
        _pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = CameraEye.transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(temp);
    }
    void LateUpdate()
    {
        _pos.x = Mathf.Lerp(_pos.x, _target.transform.position.x, Time.deltaTime * speed);
        _pos.y = Mathf.Lerp(_pos.y, _target.transform.position.y + _height, Time.deltaTime * speed);
        _pos.z = Mathf.Lerp(_pos.z, _target.transform.position.z + _distance, Time.deltaTime * speed);
        transform.position = _pos;
    }
}


