using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager6 : MonoBehaviour
{
    public int c6;
    public Text text6;
    public void Start()
    {
        c6 = 0;
    }
    public void ButClick()
    {
        c6++;
        if (c6 % 2 == 0)
        {
            text6.text = "";
        }
        else
        {
            text6.text = "Тернополь (Март 1944)";
        }
    }
}
