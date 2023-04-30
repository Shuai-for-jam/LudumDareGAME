using System.Collections;
using System.Collections.Generic;
using FluffyUnderware.Curvy;
using FluffyUnderware.Curvy.Controllers;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject bottle;
    public CurvySpline Spline1;
    public CurvySpline Spline2;
    public CurvySpline Spline3;

    private CurvySpline SplineNow;

    void Update()
    {
        SplineNow = bottle.GetComponent<SplineController>().Spline;
        if (SplineNow == Spline1)
            bottle.GetComponent<SplineController>().Clamping = CurvyClamping.Clamp;
        else
            bottle.GetComponent<SplineController>().Clamping = CurvyClamping.Loop;
        if (Input.GetKeyDown(KeyCode.S))
        {
            
        }
            if (Input.GetKeyDown(KeyCode.R))    
        {
            if (bottle.GetComponent<SplineController>().MovementDirection == MovementDirection.Forward)
                bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Backward;
            else bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Forward;
        }
    }
}
