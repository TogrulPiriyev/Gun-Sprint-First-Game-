using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveReferenceGameObject : MonoBehaviour
{
    private Camera _camera;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        x += 5;
        _camera.transform.position += new Vector3(x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
