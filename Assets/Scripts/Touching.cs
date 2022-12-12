using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touching : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Camera _camera;
    private float x;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.touchCount>0)
        {
            _rigidbody.AddForce(15f, 5f, 0);
            x += 5;
            _camera.transform.position+=new Vector3(x,0,0);
        }
    }
}