using System.Collections;
using System.Collections.Generic;
using FluffyUnderware.Curvy;
using FluffyUnderware.Curvy.Controllers;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject bottle;
    public CurvySpline spline1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            bottle.GetComponent<SplineController>().Spline = spline1;
        }
            if (Input.GetKeyDown(KeyCode.R))    //��ͷ
        {
            if (bottle.GetComponent<SplineController>().MovementDirection == MovementDirection.Forward)
                bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Backward;
            else bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Forward;
        }
    }
}
