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

    public bool isA, isB, isC, isD, isE;//判断到底是哪一个对话打开了
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
                //音效控制播放，当出现UI
            }
        }
        //瓶子和角色距离小于定值的时候，使角色头上的感叹号（characA）出现，此时若按下Q，可对UI进行操控
        if (Vector3.Distance(transform.position, characA.transform.position) > distance && canInteract == false)
        {
            characA.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //距离大于定值，感叹号（characA）不出现

        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isB == true)//这里是B对A
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characAi.enabled = true;
            characAI.SetActive(true);
            //UI图片出现

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //获取三个会出现的对话

            //if (Input.GetKeyDown(KeyCode.F))//若此处改成Q，会和前面的Q起冲突
            //{
            //    characAi.enabled = false;
            //    canInteract = false;
            //    Time.timeScale = 1;
            //}应该不会再有用的一次性文字代码

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
                    //和A交互完，获得A的信息，使其他bool都为false，保证同一时间仅有一个bool打开
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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        //上面一整段都是对于单个角色和UI等交互的代码，后续每串都是基本一直的判断
        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isC == true)//这里是C对A
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characAi.enabled = true;
            characAI.SetActive(true);
            //UI图片出现

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //获取三个会出现的对话

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
        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isD == true)//这里是D对A
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characAi.enabled = true;
            characAI.SetActive(true);
            //UI图片出现

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //获取三个会出现的对话

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
        if (canInteract == true && Vector3.Distance(transform.position, characA.transform.position) <= distance && isE == true)//这里是E对A
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characAi.enabled = true;
            characAI.SetActive(true);
            //UI图片出现

            GameObject S0, S1, S2;
            S0 = characAI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characAI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characAI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //获取三个会出现的对话

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
                //audioS.clip = characAmusic;//可以更改播放的音频，总计分两种
                //audioS.Play();
            }
        }
        //瓶子和角色距离小于定值的时候，使角色头上的感叹号（characA）出现，此时若按下Q，可对UI进行操控
        if (Vector3.Distance(transform.position, characB.transform.position) > distance && canInteract == false)
        {
            characB.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //距离大于定值，感叹号（characA）不出现

        if (canInteract == true && Vector3.Distance(transform.position, characB.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characBi.enabled = true;
            characBI.SetActive(true);
            //UI图片出现

            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //先使时间暂停
            characBi.enabled = true;
            characBI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //先使时间暂停
            characBi.enabled = true;
            characBI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //先使时间暂停
            characBi.enabled = true;
            characBI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characBI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characBI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characBI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //获取三个会出现的对话

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
                //audioS.clip = characAmusic;//可以更改播放的音频，总计分两种
                //audioS.Play();
            }
        }
        //瓶子和角色距离小于定值的时候，使角色头上的感叹号（characA）出现，此时若按下Q，可对UI进行操控
        if (Vector3.Distance(transform.position, characC.transform.position) > distance && canInteract == false)
        {
            characC.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //距离大于定值，感叹号（characA）不出现

        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characCi.enabled = true;
            characCI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isB == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characCi.enabled = true;
            characCI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isD == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characCi.enabled = true;
            characCI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characC.transform.position) <= distance && isE == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characCi.enabled = true;
            characCI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characCI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characCI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characCI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
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
                //audioS.clip = characAmusic;//可以更改播放的音频，总计分两种
                //audioS.Play();
            }
        }
        //瓶子和角色距离小于定值的时候，使角色头上的感叹号（characA）出现，此时若按下Q，可对UI进行操控
        if (Vector3.Distance(transform.position, characD.transform.position) > distance && canInteract == false)
        {
            characD.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //距离大于定值，感叹号（characA）不出现

        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characDi.enabled = true;
            characDI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(0).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(0).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isB == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characDi.enabled = true;
            characDI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(1).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(1).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(1).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isC == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characDi.enabled = true;
            characDI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(2).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(2).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(2).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characD.transform.position) <= distance && isE == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characDi.enabled = true;
            characDI.SetActive(true);
            //UI图片出现
            GameObject S0, S1, S2;
            S0 = characDI.transform.GetChild(0).GetChild(3).GetChild(0).gameObject;
            S1 = characDI.transform.GetChild(0).GetChild(3).GetChild(1).gameObject;
            S2 = characDI.transform.GetChild(0).GetChild(3).GetChild(2).gameObject;
            //获取三个会出现的对话

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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
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
                //audioS.clip = characAmusic;//可以更改播放的音频，总计分两种
                //audioS.Play();
            }
        }
        //瓶子和角色距离小于定值的时候，使角色头上的感叹号（characA）出现，此时若按下Q，可对UI进行操控
        if (Vector3.Distance(transform.position, characE.transform.position) > distance && canInteract == false)
        {
            characE.SetActive(false);
            count = 0;
            rightcol.SetActive(true);
        }
        //距离大于定值，感叹号（characA）不出现

        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isA == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characEi.enabled = true;
            characEI.SetActive(true);
            //UI图片出现
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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isB == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characEi.enabled = true;
            characEI.SetActive(true);
            //UI图片出现
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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isC == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characEi.enabled = true;
            characEI.SetActive(true);
            //UI图片出现
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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
        }
        if (canInteract == true && Vector3.Distance(transform.position, characE.transform.position) <= distance && isD == true)
        {
            Time.timeScale = 0f;
            //先使时间暂停
            characEi.enabled = true;
            characEI.SetActive(true);
            //UI图片出现
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
            //非常屎山的对话系统，确保文字能够按顺序播放，目前还不可逆
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
