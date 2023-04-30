using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision_bottle : MonoBehaviour
{

    bool canInteract;
    public GameObject characA, characB, characC, characD, characE;
    public float distance;
    public Image characAi;
    void Start()
    {
        characA = GameObject.FindGameObjectWithTag("characA");
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, characA.transform.position) <= distance&&canInteract==false)
        {
            characA.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                canInteract = true;
            }
        }
        //瓶子和角色距离小于定值的时候，使角色头上的感叹号（characA）出现，此时若按下Q，可对UI进行操控
        if (Vector3.Distance(transform.position, characA.transform.position) > distance && canInteract == false)
        {
            characA.SetActive(false);
        }
        //距离大于定值，感叹号（characA）不出现

        if (canInteract == true)
        {
            Time.timeScale = 0;
            //先使时间暂停
            characAi.enabled=true;
            //UI图片出现
            if (Input.GetKeyDown(KeyCode.Q))
            {
                characAi.enabled = false;
                Time.timeScale = 1;
            }
        }   
    }

}
