using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
 
    private void Start()
    {
        
    }
    private void Update()
    {
        Vector3 NewPos = Target.transform.position;
        NewPos.z = transform.position.z;
        transform.position = NewPos;
    }
}
