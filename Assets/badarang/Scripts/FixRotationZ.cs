using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixRotationZ : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.identity;
        //transform.Rotate(Vector3.zero, Space.World);
    }
}
