using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hourRotate : MonoBehaviour
{
    public float hourSpeed = -0.10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += hourSpeed;

        transform.eulerAngles = rot;
    }
}
