using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public int c2;
    public Text text2;
    public void Start()
    {
        c2 = 0;
    }
    public void ButClick()
    {
        c2++;
        if (c2 % 2 == 0)
        {
            text2.text = "";
        }
        else
        {
            text2.text = "Воронеж (Июнь 1942)";
        }
    }
}
