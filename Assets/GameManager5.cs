using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager5 : MonoBehaviour
{
    public int c5;
    public Text text5;
    public void Start()
    {
        c5 = 0;
    }
    public void ButClick()
    {
        c5++;
        if (c5 % 2 == 0)
        {
            text5.text = "";
        }
        else
        {
            text5.text = "Житомир (Февраль 1944)";
        }
    }
}

