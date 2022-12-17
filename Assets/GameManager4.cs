using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager4 : MonoBehaviour
{
    public int c4;
    public Text text4;
    public void Start()
    {
        c4 = 0;
    }
    public void ButClick()
    {
        c4++;
        if (c4 % 2 == 0)
        {
            text4.text = "";
        }
        else
        {
            text4.text = "Гомель (Октябрь 1943)";
        }
    }
}
