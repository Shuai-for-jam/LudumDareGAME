using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_test : MonoBehaviour
{
    public Image skillA, skillB;
    public float mana;
    void Start()
    {
        mana = 0;
    }
    void Update()
    {
        mana+=Time.deltaTime*5;
        skillB.color = new Color(1, 1, 1, mana/100);
        //Debug.Log(skillB.color);
        //skillB.fillAmount = mana / 100f;
    }
}
