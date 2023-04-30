using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour
{
    public Transform planet;
    public SphereCollider sc;
    public float maxDis;
    public bool canScale, isScale;
    public float releaseTime, pressTime;
    Vector3 startCam;

    void Start()
    {
        pressTime = 0.6f;
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<Transform>();
        startCam = transform.position;
        canScale = true;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && canScale == true)
        {
            transform.position = Vector3.Lerp(transform.position, planet.position, Time.deltaTime / 4);
        }
        if (Vector3.Distance(transform.position, planet.position) <= maxDis)
        {
            canScale = false;
        }
        //上面是长按空格放大
        if (Input.GetKeyUp(KeyCode.Space))
        {
            releaseTime = Time.time;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressTime = Time.time;
        }
        if ((Mathf.Abs(pressTime - releaseTime)) < 0.1f)
        {
            isScale = true;
        }
        if (isScale == true)
        {
            transform.position = Vector3.Lerp(transform.position, startCam, Time.deltaTime * 4);
            if (Vector3.Distance(transform.position, startCam) <= 0.01f)
            {
                isScale = false;
            }
        }
    }
}
