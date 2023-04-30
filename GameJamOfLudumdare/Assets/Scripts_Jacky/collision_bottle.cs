using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_bottle : MonoBehaviour
{
    public float mana;
    void Start()
    {
        mana =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("character"))
        {
            Debug.Log("1");
            mana += 20;
        }
    }
}
