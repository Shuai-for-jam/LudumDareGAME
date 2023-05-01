using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skills : MonoBehaviour
{
    public GameObject bottle;
    public float distance;
    public float MaxDistance;
    public Button buttonToDisable;
    //public GameObject text;

    void Start()
    {
        MaxDistance = bottle.transform.GetComponent<Movement>().MaxDistance;
    }

    void Update()
    {
        distance =bottle.transform.GetComponent<Movement>().distance;

        if(distance>MaxDistance)
        {
            //text.transform.GetComponent<Text>().color = Color.grey;
            buttonToDisable.interactable = false;


        }
        else
        {
            //text.transform.GetComponent<Text>().color = Color.white;
            buttonToDisable.interactable = true;
            
        }
    }


}
