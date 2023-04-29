using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet_selfRotate : MonoBehaviour
{
    public float speed_p = 1f ;
    void Start()
    {
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.W))
       { transform.RotateAround(Vector3.zero,Vector3.right,speed_p);}

        if(Input.GetKey(KeyCode.A))
       { transform.RotateAround(Vector3.zero,Vector3.forward,speed_p);}

        if(Input.GetKey(KeyCode.D))
       { transform.RotateAround(Vector3.zero,Vector3.back,speed_p);}

        if(Input.GetKey(KeyCode.S))
       { transform.RotateAround(Vector3.zero,Vector3.left,speed_p);}
    }
    
  
}
