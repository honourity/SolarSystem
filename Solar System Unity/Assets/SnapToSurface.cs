using System;
using UnityEngine;

public class SnapToSurface : MonoBehaviour
{
    [SerializeField] Transform _target;

    //Vector2 rotation = Vector2.zero;
    //public float speed = 3;
    
    //float polar = 0;
    //float elevation = 0;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            DoMovementAroundSurface(transform.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            DoMovementAroundSurface(transform.right, -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            DoMovementAroundSurface(transform.forward);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            DoMovementAroundSurface(transform.forward, -1);
        }

        DoAlignmentRotation();
        
        //var r = transform.rotation;
        // LateUpdate
        //polar += Input.GetAxis("Mouse X");
        //elevation -= Input.GetAxis("Mouse Y");
        //r = Quaternion.AngleAxis(Input.GetAxis("Mouse Y"), Vector3.right) * r;
        //r = Quaternion.AngleAxis(Input.GetAxis("Mouse X"), Vector3.up) * r;
        //transform.rotation = r;

        // rotation.y += Input.GetAxis("Mouse X");
        // rotation.x += -Input.GetAxis("Mouse Y");
        //
        //
        // transform.eulerAngles = rotation * speed;
        //
        // transform.rotation = Quaternion.Euler();
        // Quaternion.Euler()
    }

    void DoMovementAroundSurface(Vector3 axis, int signFactor = 1)
    {
        transform.RotateAround(_target.position, axis, signFactor * Time.deltaTime * 300f / Vector3.Distance(_target.position, transform.position));
        DoAlignmentRotation();
    }

    void DoAlignmentRotation()
    {
        transform.rotation = Quaternion.FromToRotation(transform.up, transform.position - _target.position) * transform.rotation;
    }
}
