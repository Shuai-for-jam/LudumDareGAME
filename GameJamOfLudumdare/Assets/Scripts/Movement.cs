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
    private CurvySpline SplineGoTo;

    Vector3 nearestPos1;
    Vector3 nearestPos2;

    float nearestTF1;
    float nearestTF2;
    float nearestTF;
    float distance;

    void Update()
    {
        SplineNow = bottle.GetComponent<SplineController>().Spline;

        if (SplineNow == Spline1)
            bottle.GetComponent<SplineController>().Clamping = CurvyClamping.Clamp;
        else
            bottle.GetComponent<SplineController>().Clamping = CurvyClamping.Loop;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 nearestPos;
            if (SplineNow == Spline1)
            {
                // 将target的坐标转换到spline所在的本地坐标系  
                var targetPos1 = Spline2.transform.InverseTransformPoint(target.position);
                var targetPos2 = Spline3.transform.InverseTransformPoint(target.position);
                // 获得target在spline上的最近点的TF值  
                nearestTF1 = Spline2.GetNearestPointTF(targetPos1);
                nearestTF2 = Spline3.GetNearestPointTF(targetPos2);
                // 转换到世界坐标系的spline上最近点的坐标值  
                nearestPos1 = Spline2.transform.TransformPoint(Spline2.Interpolate(nearestTF1));
                nearestPos2 = Spline3.transform.TransformPoint(Spline3.Interpolate(nearestTF2));
                float distance1 = Vector3.Distance(target.position, nearestPos1);
                float distance2 = Vector3.Distance(target.position, nearestPos2);
                if (distance1 < distance2)
                {
                    distance = distance1;
                    nearestPos = nearestPos1;
                    nearestTF = nearestTF1;
                    SplineGoTo = Spline2;
                }

                else
                {
                    distance = distance2;
                    nearestPos = nearestPos2;
                    nearestTF = nearestTF2;
                    SplineGoTo = Spline3;

                }
                Debug.Log(distance);

                if (distance <= MaxDistance)
                {

                    bottle.GetComponent<SplineController>().Spline = null;
                    StartCoroutine(MoveToNearestPos(SplineGoTo, nearestPos));
                }

                else
                    Debug.Log("bukeyi");
            }

            if (SplineNow == Spline2)
            {
                // 将target的坐标转换到spline所在的本地坐标系  
                var targetPos1 = Spline1.transform.InverseTransformPoint(target.position);
                var targetPos2 = Spline3.transform.InverseTransformPoint(target.position);
                // 获得target在spline上的最近点的TF值  
                nearestTF1 = Spline1.GetNearestPointTF(targetPos1);
                nearestTF2 = Spline3.GetNearestPointTF(targetPos2);
                // 转换到世界坐标系的spline上最近点的坐标值  
                nearestPos1 = Spline1.transform.TransformPoint(Spline1.Interpolate(nearestTF1));
                nearestPos2 = Spline3.transform.TransformPoint(Spline3.Interpolate(nearestTF2));
                float distance1 = Vector3.Distance(target.position, nearestPos1);
                float distance2 = Vector3.Distance(target.position, nearestPos2);
                if (distance1 < distance2)
                {
                    distance = distance1;
                    nearestPos = nearestPos1;
                    nearestTF = nearestTF1;
                    SplineGoTo = Spline1;
                }

                else
                {
                    distance = distance2;
                    nearestPos = nearestPos2;
                    nearestTF = nearestTF2;
                    SplineGoTo = Spline3;

                }
                Debug.Log(distance);

                if (distance <= MaxDistance)
                {

                    bottle.GetComponent<SplineController>().Spline = null;
                    StartCoroutine(MoveToNearestPos(SplineGoTo, nearestPos));
                }

                else
                    Debug.Log("bukeyi");
            }
            if (SplineNow == Spline3)
            {
                // 将target的坐标转换到spline所在的本地坐标系  
                var targetPos1 = Spline1.transform.InverseTransformPoint(target.position);
                var targetPos2 = Spline2.transform.InverseTransformPoint(target.position);
                // 获得target在spline上的最近点的TF值  
                nearestTF1 = Spline1.GetNearestPointTF(targetPos1);
                nearestTF2 = Spline2.GetNearestPointTF(targetPos2);
                // 转换到世界坐标系的spline上最近点的坐标值  
                nearestPos1 = Spline1.transform.TransformPoint(Spline1.Interpolate(nearestTF1));
                nearestPos2 = Spline2.transform.TransformPoint(Spline2.Interpolate(nearestTF2));
                float distance1 = Vector3.Distance(target.position, nearestPos1);
                float distance2 = Vector3.Distance(target.position, nearestPos2);
                if (distance1 < distance2)
                {
                    distance = distance1;
                    nearestPos = nearestPos1;
                    nearestTF = nearestTF1;
                    SplineGoTo = Spline1;
                }

                else
                {
                    distance = distance2;
                    nearestPos = nearestPos2;
                    nearestTF = nearestTF2;
                    SplineGoTo = Spline2;

                }
                Debug.Log(distance);

                if (distance <= MaxDistance)
                {

                    bottle.GetComponent<SplineController>().Spline = null;
                    StartCoroutine(MoveToNearestPos(SplineGoTo, nearestPos));
                }

                else
                    Debug.Log("bukeyi");
            }



        }

            

        if (Input.GetKeyDown(KeyCode.R))    
        {
            if (bottle.GetComponent<SplineController>().MovementDirection == MovementDirection.Forward)
                bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Backward;
            else bottle.GetComponent<SplineController>().MovementDirection = MovementDirection.Forward;
        }
    }

    IEnumerator MoveToNearestPos(CurvySpline SplineGoTo, Vector3 nearestPos)
    {
        // 计算物体到目标的距离
        float distanceToTarget = Vector3.Distance(transform.position, nearestPos);

        // 当距离大于一个很小的值（如0.001）时，继续移动物体
        while (distanceToTarget > 0.001f)
        {
            transform.position = Vector3.MoveTowards(transform.position, nearestPos, TransSpeed * Time.deltaTime);
            distanceToTarget = Vector3.Distance(transform.position, nearestPos);
            yield return null; // 等待下一帧再继续执行
        }

        // 物体到达目标后，执行后续函数  

        bottle.GetComponent<SplineController>().Spline = SplineGoTo;

        bottle.GetComponent<SplineController>().Position = nearestTF;
    }
}
