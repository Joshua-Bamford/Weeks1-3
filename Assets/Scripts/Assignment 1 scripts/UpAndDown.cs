using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    public AnimationCurve roughWaters;
    [Range(0, 1)] public float t;

    public Vector2 tideStart; 
    public Vector2 tideEnd;
    public float waveSpeed; //the rate at which each animation cycle is completed

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            t += (waveSpeed) * Time.deltaTime;    //the position in the animation cycle increases by the speed factor.
        }                                         //That is then made a constant regardless of framerate with Time.deltaTime



        //ATTENTION: the following code is more or less the same as example in required reading (https://www.youtube.com/watch?v=vZPTrFcZCSo). see my own explanation of functionality below
        transform.position = Vector2.Lerp(tideStart, tideEnd, roughWaters.Evaluate(t)); 
        //the position is set equal to the position of t between 0 and 1 which is then interpolated to match the actual value between the start and end of animation curve
    }
}
