using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime = 5;
    private Vector3 offset;
    

    void Start()
    {
        offset = transform.position - target.position;
    }
    
    void Update()
    {
        if(target.position == null)
            return;
        Vector3 cameraTarget = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, cameraTarget, smoothTime * Time.deltaTime);
    }
}
