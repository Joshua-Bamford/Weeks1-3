using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogRotation : MonoBehaviour
{
    public float rotationSpeed;
    public float rotationAcceleration;
    public float rotationDirection;
    public float maxSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 0f;
     
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 rotat = transform.eulerAngles;
        if (Input.GetMouseButton(0))
        {
            rotationAcceleration = 0.01f;   //when mouse is pressed, set acceleration to begin motion
            rotationSpeed += rotationAcceleration;  //speed increases according to the fixed rate of acceleration
            rotat.z += rotationSpeed;   //the float must be translated into the Vector3 Z value required
        }

        if (!Input.GetMouseButton(0))   //when the player lets go of the button
        {
            rotationSpeed -= rotationAcceleration;
            rotat.z -= rotationSpeed;
        }

        if(rotationSpeed >= maxSpeed)
        {
            rotationSpeed = maxSpeed; //the rotation speed of the cogs cannot go faster than this value
        }
        if(rotationSpeed <= 0)  //prevents the cogs from accelerating the other way instead of stopping
        {
            rotationSpeed = 0;
            rotationAcceleration = 0.00f;
        }
        transform.eulerAngles = rotat;  //updates the rotation of th eobject according to the float previously converted to Vector3
    }
}
