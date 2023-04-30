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
        //ƿ�Ӻͽ�ɫ����С�ڶ�ֵ��ʱ��ʹ��ɫͷ�ϵĸ�̾�ţ�characA�����֣���ʱ������Q���ɶ�UI���вٿ�
        if (Vector3.Distance(transform.position, characA.transform.position) > distance && canInteract == false)
        {
            characA.SetActive(false);
        }
        //������ڶ�ֵ����̾�ţ�characA��������

        if (canInteract == true)
        {
            Time.timeScale = 0;
            //��ʹʱ����ͣ
            characAi.enabled=true;
            //UIͼƬ����
            if (Input.GetKeyDown(KeyCode.Q))
            {
                characAi.enabled = false;
                Time.timeScale = 1;
            }
        }   
    }

}
