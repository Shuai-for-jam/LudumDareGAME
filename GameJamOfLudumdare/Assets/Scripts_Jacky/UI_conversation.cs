using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_conversation : MonoBehaviour
{
    public bool canInteract;
    public GameObject characA, characB, characC, characD, characE;
    public float distance;
    public Image characAi, characBi, characCi, characDi, characEi;
    public GameObject characAI, characBI, characCI, characDI, characEI;

    public float count;

    AudioSource audioS;
    public AudioClip characAmusic;
    AudioSource audioSB;
    public bool incVolume, decVolume;
    float rate = 0.001f;

    public bool isA, isB, isC, isD, isE;//�жϵ�������һ���Ի�����
    public GameObject leftcol, rightcol;

    public GameObject AQ, BQ, CQ, DQ, EQ;

    void Start()
    {
        //audioS = GetComponent<AudioSource>();
        //audioSB = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        //audioS.volume = 0;

        characAi = characAI.GetComponent<Image>();
        characAi.enabled = false;
        characBi = characBI.GetComponent<Image>();
        characBi.enabled = false;
        characCi = characCI.GetComponent<Image>();
        characCi.enabled = false;
        characDi = characDI.GetComponent<Image>();
        characDi.enabled = false;
        characEi = characEI.GetComponent<Image>();
        characEi.enabled = false;
        count = 0;
    }

    void Update()
    {
        //CA();
        //CB();
        //CC();
        //CD();
        CE();
        RightPanelCheck();
        //if (decVolume == true)
        //{
        //    audioSB.volume -= rate;
        //    audioS.volume += rate;
        //    Debug.Log(audioS.volume);
        //}
        //if (audioSB.volume <= 0)
        //{
        //    decVolume = false;
        //}
        //if (incVolume == true)
        //{
        //    audioSB.volume += rate;
        //    audioS.volume -= rate;
        //    Debug.Log(audioS.volume);
        //}
        //if (audioSB.volume >= 1)
        //{
        //    incVolume = false;
        //}

        
    }
    public void CA()
    {
        if (Vector3.Distance(transform.position, characA.transform.position) <= distance && canInteract == false)
        {
            characA.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                canInteract = true;
                rightcol.SetActive(false);
                //decVolume = true;
                //audioS.clip = characAmusic;
                //audioS.Play();
                //��Ч���Ʋ��ţ�������UI
            }
        }
        //ƿ�Ӻͽ�ɫ����С�ڶ�ֵ��ʱ��ʹ��ɫͷ�ϵĸ�̾�ţ�characA�����֣���ʱ������Q���ɶ�UI���вٿ�
        if (Vector3.Distance(transform.position, characA.transform.position) > distance && canInteract == false)
        {
            characA.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //������ڶ�ֵ����̾�ţ�characA��������

        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isB == true)//������B��A
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characAi.enabled = true;
            characAI.SetActive(true);
            //UIͼƬ����

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            //if (Input.GetKeyDown(KeyCode.F))//���˴��ĳ�Q�����ǰ���Q���ͻ
            //{
            //    characAi.enabled = false;
            //    canInteract = false;
            //    Time.timeScale = 1;
            //}Ӧ�ò��������õ�һ�������ִ���

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characAi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;

                    incVolume = true;

                    isA = true;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = false;
                    //��A�����꣬���A����Ϣ��ʹ����bool��Ϊfalse����֤ͬһʱ�����һ��bool��
                    characAI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        //����һ���ζ��Ƕ��ڵ�����ɫ��UI�Ƚ����Ĵ��룬����ÿ�����ǻ���һֱ���ж�
        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isC == true)//������C��A
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characAi.enabled = true;
            characAI.SetActive(true);
            //UIͼƬ����

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characAi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;

                    incVolume = true;

                    isA = true;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = false;

                    characAI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
        }
        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isD == true)//������D��A
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characAi.enabled = true;
            characAI.SetActive(true);
            //UIͼƬ����

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characAi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;

                    incVolume = true;

                    isA = true;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = false;

                    characAI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
        }
        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isE == true)//������E��A
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characAi.enabled = true;
            characAI.SetActive(true);
            //UIͼƬ����

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characAi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;

                    incVolume = true;

                    isA = true;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = false;

                    characAI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
        }
    }
    public void CB()
    {
        if (Vector3.Distance(transform.position, characB.transform.position) <= distance && canInteract == false)
        {
            characB.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                canInteract = true;
                rightcol.SetActive(false);
                //decVolume = true;
                //audioS.clip = characAmusic;//���Ը��Ĳ��ŵ���Ƶ���ܼƷ�����
                //audioS.Play();
            }
        }
        //ƿ�Ӻͽ�ɫ����С�ڶ�ֵ��ʱ��ʹ��ɫͷ�ϵĸ�̾�ţ�characA�����֣���ʱ������Q���ɶ�UI���вٿ�
        if (Vector3.Distance(transform.position, characB.transform.position) > distance && canInteract == false)
        {
            characB.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //������ڶ�ֵ����̾�ţ�characA��������

        if (canInteract == true && Vector3.Distance(transform.position, characB.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characBi.enabled = true;
            characBI.SetActive(true);
            //UIͼƬ����

            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characBi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = true;
                    isC = false;
                    isD = false;
                    isE = false;

                    characBI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
        }
        if (canInteract == true && Vector3.Distance(transform.position, characB.transform.position) <= distance && isC == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characBi.enabled = true;
            characBI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characBi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = true;
                    isC = false;
                    isD = false;
                    isE = false;

                    characBI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
        }
        if (canInteract == true && Vector3.Distance(transform.position, characB.transform.position) <= distance && isD == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characBi.enabled = true;
            characBI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characBi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = true;
                    isC = false;
                    isD = false;
                    isE = false;

                    characBI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
        }
        if (canInteract == true && Vector3.Distance(transform.position, characB.transform.position) <= distance && isE == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characBi.enabled = true;
            characBI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characBi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = true;
                    isC = false;
                    isD = false;
                    isE = false;

                    characBI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
        }
    }
    public void CC()
    {
        if (Vector3.Distance(transform.position, characC.transform.position) <= distance && canInteract == false)
        {
            characC.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                canInteract = true;
                rightcol.SetActive(false);
                //decVolume = true;
                //audioS.clip = characAmusic;//���Ը��Ĳ��ŵ���Ƶ���ܼƷ�����
                //audioS.Play();
            }
        }
        //ƿ�Ӻͽ�ɫ����С�ڶ�ֵ��ʱ��ʹ��ɫͷ�ϵĸ�̾�ţ�characA�����֣���ʱ������Q���ɶ�UI���вٿ�
        if (Vector3.Distance(transform.position, characC.transform.position) > distance && canInteract == false)
        {
            characC.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //������ڶ�ֵ����̾�ţ�characA��������

        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characCi.enabled = true;
            characCI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characCi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = true;
                    isD = false;
                    isE = false;

                    characCI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isB == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characCi.enabled = true;
            characCI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characCi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = true;
                    isD = false;
                    isE = false;

                    characCI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isD == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characCi.enabled = true;
            characCI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characCi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = true;
                    isD = false;
                    isE = false;

                    characCI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isE == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characCi.enabled = true;
            characCI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characCi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = true;
                    isD = false;
                    isE = false;

                    characCI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
    }
    public void CD()
    {
        if (Vector3.Distance(transform.position, characD.transform.position) <= distance && canInteract == false)
        {
            characD.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                canInteract = true;
                rightcol.SetActive(false);
                //decVolume = true;
                //audioS.clip = characAmusic;//���Ը��Ĳ��ŵ���Ƶ���ܼƷ�����
                //audioS.Play();
            }
        }
        //ƿ�Ӻͽ�ɫ����С�ڶ�ֵ��ʱ��ʹ��ɫͷ�ϵĸ�̾�ţ�characA�����֣���ʱ������Q���ɶ�UI���вٿ�
        if (Vector3.Distance(transform.position, characD.transform.position) > distance && canInteract == false)
        {
            characD.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //������ڶ�ֵ����̾�ţ�characA��������

        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characDi.enabled = true;
            characDI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characDi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = true;
                    isE = false;

                    characDI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isB == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characDi.enabled = true;
            characDI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characDi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = true;
                    isE = false;

                    characDI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isC == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characDi.enabled = true;
            characDI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characDi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = true;
                    isE = false;

                    characDI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isE == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characDi.enabled = true;
            characDI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //��ȡ��������ֵĶԻ�

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characDi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = true;
                    isE = false;

                    characDI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
    }
    public void CE()
    {
        if (Vector3.Distance(transform.position, characE.transform.position) <= distance && canInteract == false)
        {
            characE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                canInteract = true;
                rightcol.SetActive(false);
                //decVolume = true;
                //audioS.clip = characAmusic;//���Ը��Ĳ��ŵ���Ƶ���ܼƷ�����
                //audioS.Play();
            }
        }
        //ƿ�Ӻͽ�ɫ����С�ڶ�ֵ��ʱ��ʹ��ɫͷ�ϵĸ�̾�ţ�characA�����֣���ʱ������Q���ɶ�UI���вٿ�
        if (Vector3.Distance(transform.position, characE.transform.position) > distance && canInteract == false)
        {
            characE.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //������ڶ�ֵ����̾�ţ�characA��������

        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characEi.enabled = true;
            characEI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characEI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characEI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characEI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characEi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = true;

                    characEI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isB == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characEi.enabled = true;
            characEI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characEI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characEI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characEI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characEi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = true;

                    characEI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isC == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characEi.enabled = true;
            characEI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characEI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characEI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characEI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characEi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = true;

                    characEI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isD == true)
        {
            Time.timeScale = 0f;
            //��ʹʱ����ͣ
            characEi.enabled = true;
            characEI.SetActive(true);
            //UIͼƬ����
            GameObject S0, S1, S2;
            S0 = characEI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characEI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characEI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (count >= 3)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    characEi.enabled = false;
                    canInteract = false;
                    Time.timeScale = 1;
                    count = -1;
                    incVolume = true;

                    isA = false;
                    isB = false;
                    isC = false;
                    isD = false;
                    isE = true;

                    characEI.SetActive(false);
                }
                if (count == 2)
                {
                    S0.SetActive(false);
                    S1.SetActive(false);
                    S2.SetActive(true);
                    count++;
                }
                if (count == 1)
                {
                    S0.SetActive(false);
                    S1.SetActive(true);
                    S2.SetActive(false);
                    count++;
                }
                if (count == 0)
                {
                    S0.SetActive(true);
                    S1.SetActive(false);
                    S2.SetActive(false);
                    count++;
                }
            }
            //�ǳ�ʺɽ�ĶԻ�ϵͳ��ȷ�������ܹ���˳�򲥷ţ�Ŀǰ��������
        }
    }
    public void RightPanelCheck()
    {
        if (isA == true)
        {
            AQ.SetActive(true);
            BQ.SetActive(false);
            CQ.SetActive(false);
            DQ.SetActive(false);
            EQ.SetActive(false);
        }
        if (isB == true)
        {
            AQ.SetActive(false);
            BQ.SetActive(true);
            CQ.SetActive(false);
            DQ.SetActive(false);
            EQ.SetActive(false);
        }
        if (isC == true)
        {
            AQ.SetActive(false);
            BQ.SetActive(false);
            CQ.SetActive(true);
            DQ.SetActive(false);
            EQ.SetActive(false);
        }
        if (isD == true)
        {
            AQ.SetActive(false);
            BQ.SetActive(false);
            CQ.SetActive(false);
            DQ.SetActive(true);
            EQ.SetActive(false);
        }
        if (isE == true)
        {
            AQ.SetActive(false);
            BQ.SetActive(false);
            CQ.SetActive(false);
            DQ.SetActive(false);
            EQ.SetActive(true);
        }
    }
}
