using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
   [Range(0, 2)] public float cloudSpeed;   //Prevents clouds from going backwards and going too fast
    public AnimationCurve cloudMovement;
    [Range(0, 1)] public float t;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;   //sets the position to a Vector3 variable so that it can then be referenced

    
        if (Input.GetMouseButton(0))
        {
            t += (cloudSpeed * 2) * Time.deltaTime; //when the mouse is pressed, the animation curve moves at a rate tied to the set speed
            pos.x += (cloudSpeed * t);  //The position is updated with the current value on the curve modifying what amount of the speed is being delivered at that point
        }

        if(!Input.GetMouseButton(0) && t > 0)
        {
            t -= (cloudSpeed * 6) * Time.deltaTime; //decelerates the animation curve. it stops at a faster rate than it accelerates
            pos.x += (cloudSpeed * t);
        }


        if (pos.x > 16) //when the centrepoint of the rope reaches the edge of the screen, it respawns on the opposite side
        {               //Because there are two ropes, it gives the illusion of a pulley system or one long endless rope
            pos.x = -16;
        }
       transform.position = pos;    //update the position
    }
}
