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
    public Transform target;
    public float MaxDistance;
    public float TransSpeed;

    private CurvySpline SplineNow;


    void Update()
    {
        SplineNow = bottle.GetComponent<SplineController>().Spline;
        if (SplineNow == Spline1)
            bottle.GetComponent<SplineController>().Clamping = CurvyClamping.Clamp;
        else
            bottle.GetComponent<SplineController>().Clamping = CurvyClamping.Loop;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 将target的坐标转换到spline所在的本地坐标系  
            var targetPos = Spline3.transform.InverseTransformPoint(target.position);
            // 获得target在spline上的最近点的TF值  
            float nearestTF = Spline3.GetNearestPointTF(targetPos);
            // 转换到世界坐标系的spline上最近点的坐标值  
            var nearestPos = Spline3.transform.TransformPoint(Spline3.Interpolate(nearestTF));


            float distance = Vector3.Distance(target.position, nearestPos);
            Debug.Log(distance);
            if (distance <= MaxDistance)
            {
                //bottle.GetComponent<SplineController>().Spline = null;
                //bottle.transform.position = Vector3.MoveTowards(transform.position, nearestPos, Time.deltaTime * TransSpeed);

                bottle.GetComponent<SplineController>().Spline = Spline3;
                bottle.GetComponent<SplineController>().Position = nearestTF;


            }

            else
                Debug.Log("bukeyi");
        }

            

        if (Input.GetKeyDown(KeyCode.R))    
        {
            if (bottle.GetComponent<SplineController>().MovementDirection == MovementDirection.Forward)
                bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Backward;
            else bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Forward;
        }
    }
}
