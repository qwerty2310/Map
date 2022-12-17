using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager3 : MonoBehaviour
{
    public int c3;
    public Text text3;
    public void Start()
    {
        c3 = 0;
    }
    public void ButClick()
    {
        c3++;
        if (c3 % 2 == 0)
        {
            text3.text = "";
        }
        else
        {
            text3.text = " урск (»юль 1943)";
        }
    }
}
